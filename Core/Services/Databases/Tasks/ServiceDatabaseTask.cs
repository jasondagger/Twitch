
namespace Twitch.Core.Services.Databases.Tasks;

using Twitch.Core.Services.Databases.Models;

internal abstract class ServiceDatabaseTask<TServiceDatabaseModel, TResult>
	where TServiceDatabaseModel :
		ServiceDatabaseModel
{
	internal abstract TResult Result { get; set; }
}