
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseContext
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
        name: "type"
    )]
    public string                             Type         { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "uri"
    )]
    public string                             Uri          { get; set; } = _ = string.Empty;
}