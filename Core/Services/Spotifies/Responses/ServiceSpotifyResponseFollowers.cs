
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseFollowers
{
    [JsonPropertyName(
        name: "href"
    )]
    public string      HRef  { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "total"
    )]
    public int         Total { get; set; } = _ = 0;
}