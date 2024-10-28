
namespace Twitch.Core.Services.Databases.Tasks;

internal enum ServiceDatabaseTaskQueryType :
    uint
{
    Start = 0U,

    RetrieveListTwitchUsers,
    RetrieveSpotifyData,
    RetrieveTwitchData,
}