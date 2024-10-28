
namespace Twitch.Core.Services.Databases.Models;

using System.Data.SqlClient;

internal abstract class ServiceDatabaseModel()
{
	internal abstract void CreateFromSqlDataReader(
		SqlDataReader sqlDataReader
	);
}