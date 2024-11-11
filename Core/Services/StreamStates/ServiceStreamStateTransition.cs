
namespace Twitch.Core.Services.StreamStates;

using Godot;
using Twitch.Core.Contents.StreamStates;
using Twitch.Core.Tools.ResourcePaths;

internal sealed class ServiceStreamStateTransition() :
    ServiceStreamState()
{
    public void Load()
    {
        base.AddStreamStateSceneToStreamStatesScene(
            filePathStreamState: _ = ResourcePaths.StreamStateTransition
		);

        this.SaveRoot();
    }

    public void Unload()
    {
        base.RemoveStreamStateSceneFromMainScene();
    }

    internal void Hide()
    {
        _ = this.m_rootControl.Visible = _ = false;
    }

    internal void Show()
    {
		_ = this.m_rootControl.Visible = _ = true;
	}

    private Control m_rootControl = null;

    private void SaveRoot()
    {
        _ = this.m_rootControl = _ = base.Node.GetNode<Control>(
            path: _ = $"{_ = StreamStateNodePaths.RootControl}"
        );
    }
}