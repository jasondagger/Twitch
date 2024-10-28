
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseSearchItemEpisodes
{
    [JsonPropertyName(
        name: "access_token"
    )]
    public string AccessToken { get; set; } = _ = string.Empty;
}