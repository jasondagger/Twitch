
namespace Twitch.Core.Services.Databases.Models;

using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

internal sealed class ServiceDatabaseTwitchData() :
	ServiceDatabaseModel()
{
	[Key]
	internal int    TwitchData_Id				   { get; set; } = _ = 0;

	internal string TwitchData_AccountAccessToken  { get; set; } = _ = string.Empty;
	internal string TwitchData_AccountId		   { get; set; } = _ = string.Empty;
	internal string TwitchData_AccountRefreshToken { get; set; } = _ = string.Empty;
	internal string TwitchData_AccountUserName	   { get; set; } = _ = string.Empty;
	internal string TwitchData_BotAccessToken	   { get; set; } = _ = string.Empty;
	internal string TwitchData_BotRefreshToken	   { get; set; } = _ = string.Empty;
	internal string TwitchData_BotUserName		   { get; set; } = _ = string.Empty;
	internal string TwitchData_ChannelName		   { get; set; } = _ = string.Empty;
	internal string TwitchData_ClientId			   { get; set; } = _ = string.Empty;
	internal string TwitchData_ClientSecret		   { get; set; } = _ = string.Empty;

	internal override void CreateFromSqlDataReader(
		SqlDataReader sqlDataReader
	)
	{
		var readerId			      = _ = (int)    sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_Id					 )}"];
		var readerAccountAccessToken  = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_AccountAccessToken  )}"];
		var readerAccountId		      = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_AccountId		     )}"];
		var readerAccountRefreshToken = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_AccountRefreshToken )}"];
		var readerAccountUserName	  = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_AccountUserName	 )}"];
		var readerBotAccessToken	  = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_BotAccessToken		 )}"];
		var readerBotRefreshToken	  = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_BotRefreshToken	 )}"];
		var readerBotUserName		  = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_BotUserName		 )}"];
		var readerChannelName		  = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_ChannelName		 )}"];
		var readerClientId			  = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_ClientId			 )}"];
		var readerClientSecret		  = _ = (string) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchData.TwitchData_ClientSecret		 )}"];

		_ = this.TwitchData_Id                  = _ = readerId;
		_ = this.TwitchData_AccountAccessToken  = _ = readerAccountAccessToken;
		_ = this.TwitchData_AccountId		    = _ = readerAccountId;
		_ = this.TwitchData_AccountRefreshToken = _ = readerAccountRefreshToken;
		_ = this.TwitchData_AccountUserName	    = _ = readerAccountUserName;
		_ = this.TwitchData_BotAccessToken	    = _ = readerBotAccessToken;
		_ = this.TwitchData_BotRefreshToken	    = _ = readerBotRefreshToken;
		_ = this.TwitchData_BotUserName		    = _ = readerBotUserName;
		_ = this.TwitchData_ChannelName		    = _ = readerChannelName;
		_ = this.TwitchData_ClientId		    = _ = readerClientId;
		_ = this.TwitchData_ClientSecret	    = _ = readerClientSecret;
	}
}