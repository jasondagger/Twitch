
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseSearchItemTracks
{
    [JsonPropertyName(
        name: "href"
    )]
    public string                        HRef     { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "items"
    )]
    public ServiceSpotifyResponseTrack[] Items    { get; set; } = null;

    [JsonPropertyName(
        name: "limit"
    )]
    public int                           Limit    { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "next"
    )]
    public string                        Next     { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "offset"
    )]
    public int                           Offset   { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "previous"
    )]
    public string                        Previous { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "total"
    )]
    public int                           Total    { get; set; } = _ = 0;
}