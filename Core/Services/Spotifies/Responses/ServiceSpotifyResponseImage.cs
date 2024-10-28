
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseImage
{
    [JsonPropertyName(
        name: "height"
    )]
    public int         Height { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "url"
    )]
    public string      Url    { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "width"
    )]
    public int         Width  { get; set; } = _ = 0;
}