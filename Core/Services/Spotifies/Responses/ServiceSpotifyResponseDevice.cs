
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseDevice
{
    [JsonPropertyName(
        name: "id"
     )]
    public string                  Id               { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "is_active"
    )]
    public bool                    IsActive         { get; set; } = _ = false;

    [JsonPropertyName(
        name: "is_private_session"
    )]
    public bool                    IsPrivateSession { get; set; } = _ = false;

    [JsonPropertyName(
        name: "is_restricted"
    )]
    public bool                    IsRestricted     { get; set; } = _ = false;

    [JsonPropertyName(
        name: "name"
    )]
    public string                  Name             { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "type"
    )]
    public string                  Type             { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "volume_percent"
    )]
    public int                     VolumePercent    { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "supports_volume"
    )]
    public bool                    SupportsVolume   { get; set; } = _ = false;
}