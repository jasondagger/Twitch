
namespace Twitch.Core.Services.Databases.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

internal sealed class ServiceDatabaseSpotifyData() :
	ServiceDatabaseModel()
{
	[Key]
	internal int      SpotifyData_Id           { get; set; } = _ = 0;

	internal string   SpotifyData_AccessToken  { get; set; } = _ = string.Empty;
	internal string   SpotifyData_ClientId     { get; set; } = _ = string.Empty;
	internal string   SpotifyData_ClientSecret { get; set; } = _ = string.Empty;
	internal DateTime SpotifyData_ExpireTime   { get; set; } = _ = DateTime.MinValue;
	internal string   SpotifyData_RefreshToken { get; set; } = _ = string.Empty;

	internal override void CreateFromSqlDataReader(
		SqlDataReader sqlDataReader
	)
	{
		var readerId           = _ = (int)      sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseSpotifyData.SpotifyData_Id           )}"];
		var readerAccessToken  = _ = (string)   sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseSpotifyData.SpotifyData_AccessToken  )}"];
		var readerClientId     = _ = (string)   sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseSpotifyData.SpotifyData_ClientId     )}"];
		var readerClientSecret = _ = (string)   sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseSpotifyData.SpotifyData_ClientSecret )}"];
		var readerExpireTime   = _ = (DateTime) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseSpotifyData.SpotifyData_ExpireTime   )}"];
		var readerRefreshToken = _ = (string)   sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseSpotifyData.SpotifyData_RefreshToken )}"];

		_ = this.SpotifyData_Id           = _ = readerId;
		_ = this.SpotifyData_AccessToken  = _ = readerAccessToken;
		_ = this.SpotifyData_ClientId	  = _ = readerClientId;
		_ = this.SpotifyData_ClientSecret = _ = readerClientSecret;
		_ = this.SpotifyData_ExpireTime   = _ = readerExpireTime;
		_ = this.SpotifyData_RefreshToken = _ = readerRefreshToken;
	}
}