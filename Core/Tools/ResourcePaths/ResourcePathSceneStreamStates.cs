
namespace Twitch.Core.Tools.ResourcePaths;

internal static partial class ResourcePaths
{
    public const string StreamStates           = $"{ResourcePaths.Scenes}/{nameof(ResourcePaths.StreamStates)}";

	public const string StreamStateBeRightBack = $"{ResourcePaths.StreamStates}/{nameof(ResourcePaths.StreamStateBeRightBack)}.tscn";
	public const string StreamStateEnd         = $"{ResourcePaths.StreamStates}/{nameof(ResourcePaths.StreamStateEnd)}.tscn";
	public const string StreamStateLive        = $"{ResourcePaths.StreamStates}/{nameof(ResourcePaths.StreamStateLive)}.tscn";
	public const string StreamStateStart       = $"{ResourcePaths.StreamStates}/{nameof(ResourcePaths.StreamStateStart)}.tscn";
	public const string StreamStateTransition  = $"{ResourcePaths.StreamStates}/{nameof(ResourcePaths.StreamStateTransition)}.tscn";
}