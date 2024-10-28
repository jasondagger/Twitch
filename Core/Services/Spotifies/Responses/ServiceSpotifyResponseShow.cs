
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseShow
{
    [JsonPropertyName(
        name: "available_markets"
    )]
    public string[]                           AvailableMarkets   { get; set; } = null;

    [JsonPropertyName(
        name: "copyrights"
    )]
    public ServiceSpotifyResponseCopyrights   Copyrights         { get; set; } = null;

    [JsonPropertyName(
        name: "description"
    )]
    public string                             Description        { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "explicit"
    )]
    public bool                               Explicit           { get; set; } = _ = false;

    [JsonPropertyName(
        name: "external_urls"
    )]
    public ServiceSpotifyResponseExternalUrls ExternalUrls       { get; set; } = null;

    [JsonPropertyName(
        name: "href"
    )]
    public string                             HRef               { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "html_description"
    )]
    public string                             HtmlDescription    { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "id"
    )]
    public string                             Id                 { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "images"
    )]
    public ServiceSpotifyResponseImage[]      Images             { get; set; } = null;

    [JsonPropertyName(
        name: "is_externally_hosted"
    )]
    public bool                               IsExternallyHosted { get; set; } = _ = false;

    [JsonPropertyName(
        name: "language"
    )]
    public string[]                           Languages          { get; set; } = null;

    [JsonPropertyName(
        name: "media_type"
    )]
    public string                             MediaType          { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "name"
    )]
    public string                             Name               { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "publisher"
    )]
    public string                             Publisher          { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "type"
    )]
    public string                             Type               { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "uri"
    )]
    public string                             Uri                { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "total_episodes"
    )]
    public int                                TotalEpisodes      { get; set; } = _ = 0;
}