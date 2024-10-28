
namespace Twitch.Core.Services.Databases.Tasks;

using System;
using Twitch.Core.Services.Databases.Tasks.Retrieves;

internal static class ServiceDatabaseTaskEvents
{
    internal static Action<ServiceDatabaseTaskRetrievedListTwitchUsers> RetrievedListTwitchUsers { get; set; } = null;
    internal static Action<ServiceDatabaseTaskRetrievedSpotifyData>     RetrievedSpotifyData     { get; set; } = null;
    internal static Action<ServiceDatabaseTaskRetrievedTwitchData>      RetrievedTwitchData      { get; set; } = null;
}