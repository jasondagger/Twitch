
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseQueue
{
    [JsonPropertyName(
        name: "currently_playing"
    )]
    public ServiceSpotifyResponseTrack   CurrentlyPlaying { get; set; } = null;

    [JsonPropertyName(
        name: "queue"
    )]
    public ServiceSpotifyResponseTrack[] Queue            { get; set; } = null;
}