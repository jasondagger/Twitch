
namespace Twitch.Core.Services.StreamStates;

using Twitch.Core.Tools.ResourcePaths;

internal sealed class ServiceStreamStateBeRightBack() :
	ServiceStreamState(),
	IServiceStreamState
{
	void IServiceStreamState.Load()
	{
		base.AddStreamStateSceneToStreamStatesScene(
			filePathStreamState: _ = ResourcePaths.StreamStateBeRightBack
		);
	}

	void IServiceStreamState.Unload()
	{
		base.RemoveStreamStateSceneFromMainScene();
	}
}