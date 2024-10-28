
namespace Twitch.Core.Services.Databases.Models;

using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

internal sealed class ServiceDatabaseTwitchUser() :
	ServiceDatabaseModel()
{
	[Key]
	internal int      TwitchUser_Id									  { get; set; } = _ = 0;

	internal string   TwitchUser_CustomChatTextColor				  { get; set; } = _ = string.Empty;
	internal DateTime TwitchUser_TimeStampWhenSongRequestIsAvailable  { get; set; } = _ = DateTime.MinValue;
	internal DateTime TwitchUser_TimeStampWhenTextToSpeechIsAvailable { get; set; } = _ = DateTime.MinValue;

	internal override void CreateFromSqlDataReader(
		SqlDataReader sqlDataReader
	)
	{
		var readerId	               				   = _ = (int)      sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchUser.TwitchUser_Id                                   )}"];
		var readerCustomChatTextColor				   = _ = (string)   sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchUser.TwitchUser_CustomChatTextColor					 )}"];
		var readerTimeStampWhenSongRequestIsAvailable  = _ = (DateTime) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchUser.TwitchUser_TimeStampWhenSongRequestIsAvailable  )}"];
		var readerTimeStampWhenTextToSpeechIsAvailable = _ = (DateTime) sqlDataReader[name: _ = $"{_ = nameof( ServiceDatabaseTwitchUser.TwitchUser_TimeStampWhenTextToSpeechIsAvailable )}"];

		_ = this.TwitchUser_Id									 = _ = readerId;
		_ = this.TwitchUser_CustomChatTextColor					 = _ = readerCustomChatTextColor;
		_ = this.TwitchUser_TimeStampWhenSongRequestIsAvailable  = _ = readerTimeStampWhenSongRequestIsAvailable;
		_ = this.TwitchUser_TimeStampWhenTextToSpeechIsAvailable = _ = readerTimeStampWhenTextToSpeechIsAvailable;
	}
}