
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseAccessToken
{
    [JsonPropertyName(
        name: "access_token"
    )]
    public string             AccessToken  { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "expires_in"
    )]
    public int                ExpiresIn    { get; set; } = _ = 0;

    [JsonPropertyName(
        name: "refresh_token"
    )]
    public string             RefreshToken { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "scope"
    )]
    public string             Scope        { get; set; } = _ = string.Empty;

    [JsonPropertyName(
        name: "token_type"
    )]
    public string             TokenType    { get; set; } = _ = string.Empty;
}