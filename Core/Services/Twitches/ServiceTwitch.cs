
namespace Twitch.Core.Services.Twitches;

using System.Threading.Tasks;

public sealed partial class ServiceTwitch() :
	IService
{
	Task IService.Setup()
	{
		return _ = Task.CompletedTask;
	}

	Task IService.Start()
	{
		return _ = Task.CompletedTask;
	}

	Task IService.Stop()
	{
		return _ = Task.CompletedTask;
	}
}