
namespace Twitch.Core.Services.Spotifies;

using System;

internal sealed class ServiceSpotifyData(
	string   accessToken,
	string   clientId,
    string   clientSecret,
	DateTime expireTime,
	string   refreshToken
)
{
	internal string   AccessToken  { get; set; } = _ = accessToken;
	internal string   ClientId     { get; set; } = _ = clientId;
	internal string   ClientSecret { get; set; } = _ = clientSecret;
	internal DateTime ExpireTime   { get; set; } = _ = expireTime;
	internal string   RefreshToken { get; set; } = _ = refreshToken;
}