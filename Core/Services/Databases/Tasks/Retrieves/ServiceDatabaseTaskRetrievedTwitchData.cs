
namespace Twitch.Core.Services.Databases.Tasks.Retrieves;

using Twitch.Core.Services.Databases.Models;

internal sealed class ServiceDatabaseTaskRetrievedTwitchData(
	ServiceDatabaseTwitchData result
) :
	ServiceDatabaseTask<ServiceDatabaseTwitchData, ServiceDatabaseTwitchData>()
{
	internal override ServiceDatabaseTwitchData Result { get; set; } = _ = result;
}