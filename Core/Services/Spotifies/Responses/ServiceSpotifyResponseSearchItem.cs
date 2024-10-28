
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseSearchItem
{
    [JsonPropertyName(
        name: "albums"
    )]
    public ServiceSpotifyResponseSearchItemAlbums     Albums     { get; set; } = null;

    [JsonPropertyName(
        name: "artists"
    )]
    public ServiceSpotifyResponseSearchItemArtists    Artists    { get; set; } = null;

    [JsonPropertyName(
        name: "audiobooks"
    )]
    public ServiceSpotifyResponseSearchItemAudiobooks Audiobooks { get; set; } = null;

    [JsonPropertyName(
        name: "episodes"
    )]
    public ServiceSpotifyResponseSearchItemEpisodes   Episodes   { get; set; } = null;

    [JsonPropertyName(
        name: "playlists"
    )]
    public ServiceSpotifyResponseSearchItemPlaylists  Playlists  { get; set; } = null;

    [JsonPropertyName(
        name: "shows"
    )]
    public ServiceSpotifyResponseSearchItemShows      Shows      { get; set; } = null;

    [JsonPropertyName(
        name: "tracks"
    )]
    public ServiceSpotifyResponseSearchItemTracks     Tracks     { get; set; } = null;
}