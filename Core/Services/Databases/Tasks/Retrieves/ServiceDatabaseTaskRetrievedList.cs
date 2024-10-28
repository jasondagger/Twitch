
namespace Twitch.Core.Services.Databases.Tasks.Retrieves;

using System.Collections.Generic;
using Twitch.Core.Services.Databases.Models;

internal abstract class ServiceDatabaseTaskRetrievedList<TServiceDatabaseModel>() :
    ServiceDatabaseTask<TServiceDatabaseModel, List<TServiceDatabaseModel>>()
    where TServiceDatabaseModel :
        ServiceDatabaseModel
{

}