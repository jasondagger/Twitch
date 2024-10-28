
namespace Twitch.Core.Services.Databases.Tasks.Retrieves;

using System.Collections.Generic;
using Twitch.Core.Services.Databases.Models;

internal sealed class ServiceDatabaseTaskRetrievedListTwitchUsers(
	List<ServiceDatabaseTwitchUser> result
) :
    ServiceDatabaseTaskRetrievedList<ServiceDatabaseTwitchUser>()
{
    internal override List<ServiceDatabaseTwitchUser> Result { get; set; } = _ = result;
}