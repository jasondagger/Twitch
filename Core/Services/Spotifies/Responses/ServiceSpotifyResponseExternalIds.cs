
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseExternalIds
{
    [JsonPropertyName(
        name: "isrc"
    )]
    public string      ISRC { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "ean"
    )]
    public string      EAN { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "upc"
    )]
    public string      UPC { get; set; } = _ = string.Empty;
}