
namespace Twitch.Core.Services.Databases.Tasks.Retrieves;

using Twitch.Core.Services.Databases.Models;

internal sealed class ServiceDatabaseTaskRetrievedSpotifyData(
	ServiceDatabaseSpotifyData result
) :
	ServiceDatabaseTask<ServiceDatabaseSpotifyData, ServiceDatabaseSpotifyData>()
{
	internal override ServiceDatabaseSpotifyData Result { get; set; } = _ = result;
}