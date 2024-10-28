
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseExternalUrls
{
    [JsonPropertyName(
        name: "spotify"
    )]
    public string Spotify { get; set; } = _ = string.Empty;
}