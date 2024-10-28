
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseResumePoint
{
    [JsonPropertyName(
        name: "fully_played"
    )]
    public bool                    FullyPlayed                  { get; set; } = _ = false;

    [JsonPropertyName(
        name: "resume_position_ms"
    )]
    public string                  ResumePositionInMilliseconds { get; set; } = _ = string.Empty;
}