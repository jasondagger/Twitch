
namespace Twitch.Core.Services.Databases.Tasks;

using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Twitch.Core.Services.Databases.Models;
using Twitch.Core.Tools;

internal static class ServiceDatabaseTaskQueryHandlers
{
    internal static async Task HandleExecuteQueryAsyncRetrievedListTwitchUsers(
        SqlDataReader sqlDataReader
    )
    {
        try
        {
            ServiceDatabaseTaskEvents.RetrievedListTwitchUsers?.Invoke(
                obj: new(
                    result: _ = await ServiceDatabaseModelReader.ReadServiceDatabaseModelsFromSqlDataReaderAsync<ServiceDatabaseTwitchUser>(
						sqlDataReader: _ = sqlDataReader
					)
				)
            );
        }
        catch (Exception exception)
        {
            ConsoleLogger.LogMessageError(
                messageError: _ =
                    $"{_ = nameof(ServiceDatabaseTaskQueryHandlers)}." +
                    $"{_ = nameof(ServiceDatabaseTaskQueryHandlers.HandleExecuteQueryAsyncRetrievedListTwitchUsers)}() " +
                    $"EXCEPTION: {_ = exception.Message}"
            );
        }
    }

    internal static Task HandleExecuteQueryAsyncRetrieveSpotifyData(
        SqlDataReader sqlDataReader
    )
    {
        try
        {
            ServiceDatabaseTaskEvents.RetrievedSpotifyData.Invoke(
                obj: new(
					result: _ = ServiceDatabaseModelReader.ReadServiceDatabaseModelFromSqlDataReader<ServiceDatabaseSpotifyData>(
						sqlDataReader: _ = sqlDataReader
					)
				)
            );
        }
        catch (Exception exception)
        {
            ConsoleLogger.LogMessageError(
                messageError: _ =
                    $"{_ = nameof(ServiceDatabaseTaskQueryHandlers)}." +
                    $"{_ = nameof(ServiceDatabaseTaskQueryHandlers.HandleExecuteQueryAsyncRetrieveSpotifyData)}() " +
                    $"EXCEPTION: {_ = exception.Message}"
            );
        }

        return _ = Task.CompletedTask;
    }

    internal static Task HandleExecuteQueryAsyncRetrieveTwitchData(
        SqlDataReader sqlDataReader
    )
    {
        try
        {
            ServiceDatabaseTaskEvents.RetrievedTwitchData?.Invoke(
                obj: new(
					result: _ = ServiceDatabaseModelReader.ReadServiceDatabaseModelFromSqlDataReader<ServiceDatabaseTwitchData>(
						sqlDataReader: _ = sqlDataReader
					)
				)
            );
        }
        catch (Exception exception)
        {
            ConsoleLogger.LogMessageError(
                messageError: _ =
                    $"{_ = nameof(ServiceDatabaseTaskQueryHandlers)}." +
                    $"{_ = nameof(ServiceDatabaseTaskQueryHandlers.HandleExecuteQueryAsyncRetrieveTwitchData)}() " +
                    $"EXCEPTION: {_ = exception.Message}"
            );
        }

        return _ = Task.CompletedTask;
	}
}