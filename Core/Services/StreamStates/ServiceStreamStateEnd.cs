
namespace Twitch.Core.Services.StreamStates;

using Twitch.Core.Tools.ResourcePaths;

internal sealed class ServiceStreamStateEnd() :
	ServiceStreamState(),
	IServiceStreamState
{
	void IServiceStreamState.Load()
	{
		base.AddStreamStateSceneToStreamStatesScene(
			filePathStreamState: _ = ResourcePaths.StreamStateEnd
		);
	}

	void IServiceStreamState.Unload()
	{
		base.RemoveStreamStateSceneFromMainScene();
	}
}