
namespace Twitch.Core.Services.Spotifies;

using System;
using System.Data;
using System.Threading.Tasks;
using Twitch.Core.Services.Databases;
using Twitch.Core.Services.Databases.Models;
using Twitch.Core.Services.Databases.Tasks;
using Twitch.Core.Services.Databases.Tasks.Retrieves;
using Twitch.Core.Services.Spotifies.Responses;

internal sealed partial class ServiceSpotify() :
	IService
{
	Task IService.Setup()
	{
		this.SubscribeToDatabaseEvents();
		return _ = Task.CompletedTask;
	}

	Task IService.Start()
	{
		return _ = Task.CompletedTask;
	}

	Task IService.Stop()
	{
		return _ = Task.CompletedTask;
	}

	private const int		   c_spotifyAccessTokenExpireTimeInHours = 1;
	private ServiceSpotifyData m_serviceSpotifyData					 = null;

	private void OnRetrievedSpotifyData(
		ServiceDatabaseTaskRetrievedSpotifyData serviceDatabaseTaskRetrievedSpotifyData
	)
	{
		var result = _ = serviceDatabaseTaskRetrievedSpotifyData.Result;

		_ = this.m_serviceSpotifyData = new(
			accessToken:  _ = result.SpotifyData_AccessToken,
			clientId:     _ = result.SpotifyData_ClientId,
			clientSecret: _ = result.SpotifyData_ClientSecret,
			expireTime:   _ = result.SpotifyData_ExpireTime,
			refreshToken: _ = result.SpotifyData_RefreshToken
		);

		// todo: compare expiration times & refresh if needed -> spotify auth flow -> StoreAccessToken()
	}

	private void StoreAccessToken(
		ServiceSpotifyResponseAccessToken response,
		bool						      wasRefreshed
	)
	{
		_ = this.m_serviceSpotifyData.AccessToken = _ = response.AccessToken;
		_ = this.m_serviceSpotifyData.ExpireTime  = _ = DateTime.UtcNow.AddHours(
			value: _ = ServiceSpotify.c_spotifyAccessTokenExpireTimeInHours
		);
		if (_ = wasRefreshed is false)
		{
			_ = this.m_serviceSpotifyData.RefreshToken = _ = response.RefreshToken;
		}

		ServiceDatabase.ExecuteTaskNonQuery(
			serviceDatabaseTaskNonQueryType:  _ = ServiceDatabaseTaskNonQueryType.StoreSpotifyData,
			serviceDatabaseTaskSqlParameters: [
				new(
					parameterName: _ = $"{_ = nameof(ServiceDatabaseSpotifyData.SpotifyData_AccessToken)}",
					sqlDbType:	   _ = SqlDbType.VarChar,
					value:		   _ = this.m_serviceSpotifyData.AccessToken
				),
				new(
					parameterName: _ = $"{_ = nameof(ServiceDatabaseSpotifyData.SpotifyData_ExpireTime)}",
					sqlDbType:     _ = SqlDbType.DateTime2,
					value:         _ = this.m_serviceSpotifyData.ExpireTime
				),
				new(
					parameterName: _ = $"{_ = nameof(ServiceDatabaseSpotifyData.SpotifyData_RefreshToken)}",
					sqlDbType:     _ = SqlDbType.VarChar,
					value:         _ = this.m_serviceSpotifyData.RefreshToken
				),
			]
		);
	}

	private void SubscribeToDatabaseEvents()
	{
		_ = ServiceDatabaseTaskEvents.RetrievedSpotifyData += this.OnRetrievedSpotifyData;
	}
}