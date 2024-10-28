
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseAlbum
{
    [JsonPropertyName(
        name: "album_type"
    )]
    public string                                   AlbumnType           { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "artists"
    )]
    public ServiceSpotifyResponseSimplifiedArtist[] Artists              { get; set; } = null;

    [JsonPropertyName(
        name: "available_markets"
    )]
    public string[]                                 AvailableMarkets     { get; set; } = null;

    [JsonPropertyName(
        name: "external_urls"
    )]
    public ServiceSpotifyResponseExternalUrls       ExternalUrls         { get; set; } = null;

    [JsonPropertyName(
        name: "href"
    )]
    public string                                   HRef                 { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "id"
    )]
    public string                                   Id                   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "images"
    )]
    public ServiceSpotifyResponseImage[]            Images               { get; set; } = null;

    [JsonPropertyName(
        name: "name"
    )]
    public string                                   Name                 { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "release_date"
    )]
    public string                                   ReleaseDate          { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "release_date_precision"
    )]
    public string                                   ReleaseDatePrecision { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "restrictions"
    )]
    public ServiceSpotifyResponseRestrictions       Restrictions         { get; set; } = null;
    
    [JsonPropertyName(
        name: "total_tracks"
    )]
    public int                                      TotalTracks          { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "type"
    )]
    public string                                   Type                 { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "uri"
    )]
    public string                                   Uri                  { get; set; } = _ = string.Empty;
}