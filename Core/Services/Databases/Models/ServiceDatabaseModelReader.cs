
namespace Twitch.Core.Services.Databases.Models;

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

internal static class ServiceDatabaseModelReader
{
	static ServiceDatabaseModelReader()
	{

	}

	internal static async Task<List<TServiceDatabaseModel>> ReadServiceDatabaseModelsFromSqlDataReaderAsync<TServiceDatabaseModel>(
		SqlDataReader sqlDataReader
	) where TServiceDatabaseModel :
		ServiceDatabaseModel,
		new()
	{
		var serviceDatabaseModels = _ = new List<TServiceDatabaseModel>();

		while (true)
		{
			var hasRecordAvailable = _ = await sqlDataReader.ReadAsync();
			if (_ = hasRecordAvailable is false)
			{
				break;
			}

			serviceDatabaseModels.Add(
				item: _ = ServiceDatabaseModelReader.CreateServiceDatabaseModelFromSqlDataReader<TServiceDatabaseModel>(
					sqlDataReader: _ = sqlDataReader
				)
			);
		}

		return _ = serviceDatabaseModels;
	}

	internal static TServiceDatabaseModel ReadServiceDatabaseModelFromSqlDataReader<TServiceDatabaseModel>(
		SqlDataReader sqlDataReader
	) where TServiceDatabaseModel :
		ServiceDatabaseModel,
		new()
	{
		var hasRecordAvailable = _ = sqlDataReader.Read();
		if (_ = hasRecordAvailable is true)
		{
			return _ = ServiceDatabaseModelReader.CreateServiceDatabaseModelFromSqlDataReader<TServiceDatabaseModel>(
				sqlDataReader: _ = sqlDataReader
			);
		}

		return null;
	}

	private static TServiceDatabaseModel CreateServiceDatabaseModelFromSqlDataReader<TServiceDatabaseModel>(
		SqlDataReader sqlDataReader
	) where TServiceDatabaseModel :
		ServiceDatabaseModel,
		new()
	{
		var serviceDatabaseModel = _ = new TServiceDatabaseModel();

		serviceDatabaseModel.CreateFromSqlDataReader(
			sqlDataReader: _ = sqlDataReader
		);

		return _ = serviceDatabaseModel;
	}
}