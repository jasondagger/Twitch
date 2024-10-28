
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponsePlaybackState
{
    [JsonPropertyName(
        name: "device"
    )]
    public ServiceSpotifyResponseDevice Device                 { get; set; } = null;

    [JsonPropertyName(
        name: "repeat_state"
    )]
    public string                       RepeatState            { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "shuffle_state"
    )]
    public bool                         ShuffleState           { get; set; } = _ = false;

    [JsonPropertyName(
        name: "timestamp"
    )]
    public int                          TimeStamp              { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "progress_ms"
    )]
    public int                          ProgressInMilliseconds { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "is_playing"
    )]
    public bool                         IsPlaying              { get; set; } = _ = false;

    [JsonPropertyName(
        name: "currently_playing_type"
    )]
    public string                       CurrentlyPlayingType   { get; set; } = _ = string.Empty;
}