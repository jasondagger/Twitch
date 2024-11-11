
namespace Twitch.Core.Services.StreamStates;

using Twitch.Core.Tools.ResourcePaths;

internal sealed class ServiceStreamStateLive() :
	ServiceStreamState(),
	IServiceStreamState
{
	void IServiceStreamState.Load()
	{
		base.AddStreamStateSceneToStreamStatesScene(
			filePathStreamState: _ = ResourcePaths.StreamStateLive
		);
	}

	void IServiceStreamState.Unload()
	{
		base.RemoveStreamStateSceneFromMainScene();
	}
}