
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseSimplifiedArtist
{
    [JsonPropertyName(
        name: "external_urls"
    )]
    public ServiceSpotifyResponseExternalUrls ExternalUrls { get; set; } = null;

    [JsonPropertyName(
        name: "href"
    )]
    public string                             HRef         { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "id"
    )]
    public string                             Id           { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "name"
    )]
    public string                             Name         { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "type"
    )]
    public string                             Type         { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "uri"
    )]
    public string                             Uri          { get; set; } = _ = string.Empty;
}