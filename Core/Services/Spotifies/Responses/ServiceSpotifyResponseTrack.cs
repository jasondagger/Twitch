
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseTrack
{
    [JsonPropertyName(
        name: "album"
    )]
    public ServiceSpotifyResponseAlbum        Album                  { get; set; } = null;

    [JsonPropertyName(
        name: "artists"
    )]
    public ServiceSpotifyResponseArtist[]     Artists                { get; set; } = null;

    [JsonPropertyName(
        name: "available_markets"
    )]
    public string[]                           AvailableMarkets       { get; set; } = null;

    [JsonPropertyName(
        name: "disc_number"
    )]
    public int                                DiscNumber             { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "duration_ms"
    )]
    public int                                DurationInMilliseconds { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "explicit"
    )]
    public bool                               Explicit               { get; set; } = _ = false;

    [JsonPropertyName(
        name: "external_ids"
    )]
    public ServiceSpotifyResponseExternalIds  ExternalIds            { get; set; } = null;

    [JsonPropertyName(
        name: "external_urls"
    )]
    public ServiceSpotifyResponseExternalUrls ExternalUrls           { get; set; } = null;

    [JsonPropertyName(
        name: "href"
    )]
    public string                             HRef                   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "id"
    )]
    public string                             Id                     { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "is_local"
    )]
    public bool                               IsLocal                { get; set; } = _ = false;

    [JsonPropertyName(
        name: "is_playable"
    )]
    public bool                               IsPlayable             { get; set; } = _ = false;

    [JsonPropertyName(
        name: "linked_from"
    )]
    public ServiceSpotifyResponseLinkedFrom   LinkedFrom             { get; set; } = null;

    [JsonPropertyName(
        name: "name"
    )]
    public string                             Name                   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "popularity"
    )]
    public int                                Popularity             { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "preview_url"
    )]
    public string                             PreviewUrl             { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "restrictions"
    )]
    public ServiceSpotifyResponseRestrictions Restrictions           { get; set; } = null;

    [JsonPropertyName(
        name: "track_number"
    )]
    public int                                TrackNumber            { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "type"
    )]
    public string                             Type                   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "uri"
    )]
    public string                             Uri                    { get; set; } = _ = string.Empty;
}