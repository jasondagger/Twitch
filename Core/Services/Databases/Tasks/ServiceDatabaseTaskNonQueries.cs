
namespace Twitch.Core.Services.Databases.Tasks;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal static class ServiceDatabaseTaskNonQueries
{
    static ServiceDatabaseTaskNonQueries()
    {

    }

    internal static async Task ExecuteAsyncNonQuery(
        ServiceDatabaseTaskNonQueryType       serviceDatabaseTaskNonQueryType,
		List<ServiceDatabaseTaskSqlParameter> serviceDatabaseTaskSqlParameters
	)
	{
        await ServiceDatabaseTaskNonQueries.c_taskNonQueries[
            key: _ = serviceDatabaseTaskNonQueryType
        ].Invoke(
            arg: _ = serviceDatabaseTaskSqlParameters
        );
    }

    private static readonly Dictionary<ServiceDatabaseTaskNonQueryType, Func<List<ServiceDatabaseTaskSqlParameter>, Task>> c_taskNonQueries = new()
    {
        {
            _ = ServiceDatabaseTaskNonQueryType.StoreSpotifyData, 
            ServiceDatabaseTaskNonQueries.StoreAsyncSpotifyData
        },
	};

    private static async Task StoreAsyncSpotifyData(
        List<ServiceDatabaseTaskSqlParameter> serviceDatabaseTaskSqlParameters
	)
	{
        // todo: not correct sql statement
		var sqlStatement = _ = $"SELECT * FROM TwitchUsers";
		await ServiceDatabaseTaskLogic.ExecuteNonQueryAsync(
            sqlStatement:                     _ = sqlStatement,
            serviceDatabaseTaskSqlParameters: _ = serviceDatabaseTaskSqlParameters
		);
    }
};