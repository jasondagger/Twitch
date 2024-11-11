
namespace Twitch;

using Godot;
using System;
using Twitch.Core.Services;

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
					$"EXCEPTION: Duplicate '{_ = nameof(Main)}' detected."
			);
		}
#endif

		_ = Main.Node = _ = this;

		await Services.Start();
	}
}