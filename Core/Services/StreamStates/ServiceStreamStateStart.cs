
namespace Twitch.Core.Services.StreamStates;

using Twitch.Core.Tools.ResourcePaths;

internal sealed class ServiceStreamStateStart() :
	ServiceStreamState(),
	IServiceStreamState
{
	void IServiceStreamState.Load()
	{
		base.AddStreamStateSceneToStreamStatesScene(
			filePathStreamState: _ = ResourcePaths.StreamStateStart
		);
	}

	void IServiceStreamState.Unload()
	{
		base.RemoveStreamStateSceneFromMainScene();
	}
}