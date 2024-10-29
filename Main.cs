
namespace Twitch;

using Godot;
using System;
using System.Runtime.Versioning;
using Twitch.Core.Services;

[SupportedOSPlatform(
	"windows"
)]
internal sealed partial class Main() :
	Node()
{
	internal static Node Node { get; private set; } = null;

	public override async void _EnterTree()
	{
#if DEBUG
		if (_ = Main.Node is not null)
		{
			throw _ = new Exception(
				message: _ =
					$"EXCEPTION: " +
					$"{_ = nameof(Main)}." +
					$"{_ = nameof(Main.Node)} - " +
					$"Duplicate '{_ = nameof(Main)}' detected."
			);
		}
#endif

		_ = Main.Node = _ = this;

		await Services.Start();
	}
}