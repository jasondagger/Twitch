
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseCopyrights
{
    [JsonPropertyName(
        name: "text"
    )]
    public string      Text { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "type"
    )]
    public string      Type { get; set; } = _ = string.Empty;
}