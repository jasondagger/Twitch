
namespace Twitch.Core.Services.WebCams;

using Godot;
using OpenCvSharp;
using System.Threading.Tasks;

internal sealed partial class ServiceWebCam() :
	IService
{
	Task IService.Setup() 
	{
		this.CaptureVideoCaptureDeviceFromOperatingSystem();
		return _ = Task.CompletedTask;
	}

	Task IService.Start()
	{
		return _ = Task.CompletedTask;
	}

	Task IService.Stop()
	{
		this.ReleaseVideoCaptureDevice();
		return _ = Task.CompletedTask;
	}

	internal ImageTexture GetWebCamImageTexture()
	{
		using var frame    = _ = new Mat();
		var webCamHasImage = _ = this.m_videoCapture.Read(
			image: _ = frame
		);

		if (_ = webCamHasImage)
		{
			var frameAsPng = _ = frame.ToBytes(
				ext: _ = ServiceWebCam.c_targetImageExtension
			);
			var error      = _ = this.m_image.LoadPngFromBuffer(
				buffer: _ = frameAsPng
			);

			if (_ = error is Error.Ok)
			{
				return _ = ImageTexture.CreateFromImage(
					image: _ = this.m_image
				);
			}
		}

		return null;
	}

	private const string   c_targetImageExtension = $".png";
	private const int      c_targetVideoCaptureId = 0;
	private readonly Image m_image				  = new();
	private VideoCapture   m_videoCapture		  = null;

	private void ReleaseVideoCaptureDevice()
	{
		this.m_videoCapture.Release();
	}

	private void CaptureVideoCaptureDeviceFromOperatingSystem()
	{
		_ = this.m_videoCapture = _ = VideoCapture.FromCamera(
			index: _ = ServiceWebCam.c_targetVideoCaptureId
		);
	}
}