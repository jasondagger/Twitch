

namespace Twitch.Core.Services.Databases.Tasks;

internal static class ServiceDatabaseTaskQueryStatements
{
	static ServiceDatabaseTaskQueryStatements()
	{

	}

	internal const string RetrieveListTwitchUsers = $"SELECT * FROM TwitchUsers";
	internal const string RetrieveSpotifyData     = $"SELECT TOP 1 FROM SpotifyDatas";
	internal const string RetrieveTwitchData      = $"SELECT TOP 1 FROM TwitchDatas";
}