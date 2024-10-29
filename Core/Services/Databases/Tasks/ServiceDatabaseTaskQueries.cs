
namespace Twitch.Core.Services.Databases.Tasks;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

internal static class ServiceDatabaseTaskQueries
{
    static ServiceDatabaseTaskQueries()
    {

    }

    internal static async Task ExecuteAsyncQuery(
        ServiceDatabaseTaskQueryType serviceDatabaseTaskQueryType
    )
    {
        await ServiceDatabaseTaskQueries.c_taskQueries[ key: _ = serviceDatabaseTaskQueryType ].Invoke();
    }

    private static readonly Dictionary<ServiceDatabaseTaskQueryType, Func<Task>> c_taskQueries = new()
    {
        { _ = ServiceDatabaseTaskQueryType.Start,                   ServiceDatabaseTaskQueries.Start                        },
        { _ = ServiceDatabaseTaskQueryType.RetrieveListTwitchUsers, ServiceDatabaseTaskQueries.RetrieveAsyncListTwitchUsers },
        { _ = ServiceDatabaseTaskQueryType.RetrieveSpotifyData,     ServiceDatabaseTaskQueries.RetrieveAsyncSpotifyData     },
        { _ = ServiceDatabaseTaskQueryType.RetrieveTwitchData,      ServiceDatabaseTaskQueries.RetrieveAsyncTwitchData      },
	};

	private static async Task RetrieveAsyncListTwitchUsers()
	{
		var sqlStatement = _ = ServiceDatabaseTaskQueryStatements.RetrieveListTwitchUsers;
		await ServiceDatabaseTaskLogic.ExecuteQueryAsync(
			sqlStatement:			  _ = sqlStatement,
			executeQueryAsyncHandler: ServiceDatabaseTaskQueryHandlers.HandleExecuteQueryAsyncRetrievedListTwitchUsers
		);
	}

	private static async Task RetrieveAsyncSpotifyData()
    {
		var sqlStatement = _ = ServiceDatabaseTaskQueryStatements.RetrieveSpotifyData;
		await ServiceDatabaseTaskLogic.ExecuteQueryAsync(
			sqlStatement:			  _ = sqlStatement,
			executeQueryAsyncHandler: ServiceDatabaseTaskQueryHandlers.HandleExecuteQueryAsyncRetrieveSpotifyData
		);
	}

    private static async Task RetrieveAsyncTwitchData()
    {
		var sqlStatement = _ = ServiceDatabaseTaskQueryStatements.RetrieveTwitchData;
		await ServiceDatabaseTaskLogic.ExecuteQueryAsync(
			sqlStatement:			  _ = sqlStatement,
			executeQueryAsyncHandler: ServiceDatabaseTaskQueryHandlers.HandleExecuteQueryAsyncRetrieveTwitchData
		);
	}

	private static async Task Start()
    {
        await ServiceDatabaseTaskQueries.RetrieveAsyncTwitchData();
        await ServiceDatabaseTaskQueries.RetrieveAsyncSpotifyData();
		await ServiceDatabaseTaskQueries.RetrieveAsyncListTwitchUsers();
	}
};