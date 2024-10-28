
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseRestrictions
{
    [JsonPropertyName(
        name: "reason"
    )]
    public string Reason { get; set; } = _ = string.Empty;
}