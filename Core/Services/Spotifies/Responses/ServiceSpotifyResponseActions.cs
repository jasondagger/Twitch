
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseActions
{
    [JsonPropertyName(
        name: "interrupting_playback"
    )]
    public bool                         InterruptingPlayback  { get; set; } = _ = false;

    [JsonPropertyName(
        name: "pausing"
    )]
    public bool                         Pausing               { get; set; } = _ = false;

    [JsonPropertyName(
        name: "resuming"
    )]
    public bool                         Resuming              { get; set; } = _ = false;

    [JsonPropertyName(
        name: "seeking"
    )]
    public bool                         Seeking               { get; set; } = _ = false;

    [JsonPropertyName(
        name: "skipping_next"
    )]
    public bool                         SkippingNext          { get; set; } = _ = false;

    [JsonPropertyName(
        name: "skipping_prev"
    )]
    public bool                         SkippingPrevious      { get; set; } = _ = false;

    [JsonPropertyName(
        name: "toggling_repeat_context"
    )]
    public bool                         TogglingRepeatContext { get; set; } = _ = false;

    [JsonPropertyName(
        name: "toggling_repeat_track"
    )]
    public bool                         TogglingRepeatTrack   { get; set; } = _ = false;


    [JsonPropertyName(
        name: "toggling_shuffle"
    )]
    public bool                         TogglingShuffle       { get; set; } = _ = false;

    [JsonPropertyName(
        name: "transferring_playback"
    )]
    public bool                         TransferringPlayback  { get; set; } = _ = false;
}