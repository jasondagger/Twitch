
namespace Twitch.Core.Contents.StreamStates.Lives.Controls.WebCams;

using Godot;
using Twitch.Core.Services.WebCams;
using Services = Services.Services;

internal sealed partial class WebCam() :
	Node()
{
	public override void _Process(
		double delta
	)
	{
		base._Process(
			delta: _ = delta
		);

		this.UpdateTextureRectTargetWithWebCamImageTexture();
	}

	public override void _Ready()
	{
		base._Ready();

		this.RetrieveServiceWebCam();
		this.RetrieveTextureRectTarget();
	}

	private const string  c_nodePathTextureRectTarget = $"{nameof(TextureRect)}";
	private ServiceWebCam m_serviceWebCam             = null;
	private TextureRect   m_textureRectTarget         = null;

	private void RetrieveServiceWebCam()
	{
		_ = this.m_serviceWebCam = _ = Services.GetService<ServiceWebCam>();
	}

	private void RetrieveTextureRectTarget()
	{
		_ = this.m_textureRectTarget = _ = base.GetNode<TextureRect>(
			path: _ = WebCam.c_nodePathTextureRectTarget
		);
	}

	private void UpdateTextureRectTargetWithWebCamImageTexture()
	{
		var webCamImageTexture = _ = this.m_serviceWebCam.GetWebCamImageTexture();

		// todo: clip green pixels 0x00FF00

		_ = this.m_textureRectTarget.Texture = _ = webCamImageTexture;
	}
}