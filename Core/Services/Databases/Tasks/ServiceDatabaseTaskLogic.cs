
namespace Twitch.Core.Services.Databases.Tasks;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Twitch.Core.Tools;

internal static class ServiceDatabaseTaskLogic
{
    internal delegate Task ExecuteTaskQueryAsyncHandler(
        SqlDataReader sqlDataReader
    );

    internal static async Task ExecuteNonQueryAsync(
        string                                sqlStatement,
        List<ServiceDatabaseTaskSqlParameter> serviceDatabaseTaskSqlParameters
    )
    {
        try
        {
            await using var sqlConnection = _ = new SqlConnection(
                connectionString: _ = ServiceDatabaseTaskLogic.c_connectionString
            );
            await sqlConnection.OpenAsync();

            await ServiceDatabaseTaskLogic.StartTransactionExecuteNonQueryAsync(
                sqlConnection:                    _ = sqlConnection,
                sqlStatement:                     _ = sqlStatement,
                serviceDatabaseTaskSqlParameters: _ = serviceDatabaseTaskSqlParameters
            );
        }
        catch (Exception exception)
        {
            ConsoleLogger.LogMessageError(
                messageError: _ =
                    $"{_ = nameof(ServiceDatabaseTaskLogic)}." +
                    $"{_ = nameof(ServiceDatabaseTaskLogic.ExecuteNonQueryAsync)}() - " +
                    $"EXCEPTION: {_ = exception.Message}"
            );
        }
    }

    internal static async Task ExecuteQueryAsync(
        string                       sqlStatement,
        ExecuteTaskQueryAsyncHandler executeQueryAsyncHandler
    )
    {
        try
        {
            await using var sqlConnection = _ = new SqlConnection(
                connectionString: _ = ServiceDatabaseTaskLogic.c_connectionString
			);
            await sqlConnection.OpenAsync();

            await using var sqlCommand = _ = new SqlCommand(
                cmdText:    _ = sqlStatement,
                connection: _ = sqlConnection
            );
            await using var sqlDataReader = _ = await sqlCommand.ExecuteReaderAsync();
            await executeQueryAsyncHandler.Invoke(
                sqlDataReader: _ = sqlDataReader
			);
        }
        catch (Exception exception)
        {
            ConsoleLogger.LogMessageError(
                messageError: _ =
                    $"{_ = nameof(ServiceDatabaseTaskLogic)}." +
                    $"{_ = nameof(ServiceDatabaseTaskLogic.ExecuteQueryAsync)}() EXCEPTION: - " +
                    $"EXCEPTION: {_ = exception.Message}"
            );
        }
    }

    internal static async Task<bool> TestConnection()
    {
        try
        {
            await using var sqlConnection = _ = new SqlConnection(
                connectionString: _ = ServiceDatabaseTaskLogic.c_connectionString
			);
            await sqlConnection.OpenAsync();

            return _ = true;
        }
        catch (Exception exception)
        {
            ConsoleLogger.LogMessageError(
                messageError: _ =
                    $"{_ = nameof(ServiceDatabaseTaskLogic)}." +
                    $"{_ = nameof(ServiceDatabaseTaskLogic.TestConnection)}() - " +
                    $"EXCEPTION: {_ = exception.Message}"
            );
        }
        return false;
    }

    private const string c_connectionString =
        $"Server=(localdb)\\Twitch;" +
        $"Database=Live;"     +
        $"Trusted_Connection=True;";

    private static async Task CompleteTransactionExecuteQueryAsync(
        SqlTransaction sqlTransaction,
        SqlCommand     sqlCommand
    )
    {
        try
        {
            _ = await sqlCommand.ExecuteNonQueryAsync();
            await sqlTransaction.CommitAsync();
        }
        catch (Exception exception)
        {
            await sqlTransaction.RollbackAsync();
            ConsoleLogger.LogMessageError(
                messageError: _ =
                    $"{_ = nameof(ServiceDatabaseTaskLogic)}." +
                    $"{_ = nameof(ServiceDatabaseTaskLogic.CompleteTransactionExecuteQueryAsync)}() - " +
                    $"EXCEPTION: {_ = exception.Message}"
            );
        }
    }

    private static async Task StartTransactionExecuteNonQueryAsync(
        SqlConnection                         sqlConnection,
        string                                sqlStatement,
        List<ServiceDatabaseTaskSqlParameter> serviceDatabaseTaskSqlParameters
    )
    {
        try
        {
            await using var databaseTransaction = _ = await sqlConnection.BeginTransactionAsync();

            var sqlTransaction = _ = databaseTransaction as SqlTransaction;
            if (sqlTransaction is not null)
            {
                await using var sqlCommand = _ = new SqlCommand(
                    cmdText:     _ = sqlStatement,
                    connection:  _ = sqlConnection,
                    transaction: _ = sqlTransaction
                );
                foreach (var serviceDatabaseTaskSqlParameter in _ = serviceDatabaseTaskSqlParameters)
                {
                    var parameterName = _ = serviceDatabaseTaskSqlParameter.ParameterName;
                    var value         = _ = serviceDatabaseTaskSqlParameter.Value;
                    var sqlDbType     = _ = serviceDatabaseTaskSqlParameter.SqlDbType;

                    var sqlParameter = _ = new SqlParameter(
                        parameterName: _ = parameterName,
                        dbType:        _ = sqlDbType
                    )
                    {
                        Value = _ = value
					};

                    _ = sqlCommand.Parameters.Add(
                        value: _ = sqlParameter
					);
                }

                await ServiceDatabaseTaskLogic.CompleteTransactionExecuteQueryAsync(
                    sqlTransaction: _ = sqlTransaction,
                    sqlCommand:     _ = sqlCommand
                );
            }
        }
        catch (Exception exception)
        {
            ConsoleLogger.LogMessageError(
                messageError: _ =
                    $"{_ = nameof(ServiceDatabaseTaskLogic)}." +
                    $"{_ = nameof(ServiceDatabaseTaskLogic.StartTransactionExecuteNonQueryAsync)}() - " +
                    $"EXCEPTION: {_ = exception.Message}"
            );
        }
    }
}