
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseDevices
{
    [JsonPropertyName(
        name: "devices"
    )]
    public ServiceSpotifyResponseDevice[] Devices { get; set; } = null;
}