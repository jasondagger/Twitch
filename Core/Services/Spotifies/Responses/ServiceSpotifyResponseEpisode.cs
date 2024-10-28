
namespace Twitch.Core.Services.Spotifies.Responses;

using System;
using System.Text.Json.Serialization;

[Serializable]
public sealed class ServiceSpotifyResponseEpisode
{
    [JsonPropertyName(
		name: "audio_preview_url"
	)]
	public string							  AudioPreviewUrl	   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "description"
	)]
	public string							  Description		   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "duration_ms"
	)]
	public int								  DurationMS		   { get; set; } = _ = 0;

    [JsonPropertyName(
		name: "explicit"
	)]
	public bool								  Explicit			   { get; set; } = _ = false;

    [JsonPropertyName(
		name: "external_urls"
	)]
	public ServiceSpotifyResponseExternalUrls ExternalUrls		   { get; set; } = null;

    [JsonPropertyName(
		name: "href"
	)]
	public string							  HRef				   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "html_description"
	)]
	public string							  HtmlDescription	   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "id"
	)]
	public string							  Id				   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "images"
	)]
	public ServiceSpotifyResponseImage[]	  Images			   { get; set; } = null;

    [JsonPropertyName(
		name: "is_externally_hosted"
	)]
	public bool								  IsExternallyHosted   { get; set; } = _ = false;

    [JsonPropertyName(
		name: "is_playable"
	)]
	public bool								  IsPlayable		   { get; set; } = _ = false;

    [JsonPropertyName(
		name: "language"
	)]
	public string							  Language			   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "languages"
	)]
	public string[]							  Languages			   { get; set; } = null;

    [JsonPropertyName(
		name: "name"
	)]
	public string							  Name				   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "release_date"
	)]
	public string							  ReleaseDate		   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "release_date_precision"
	)]
	public string							  ReleaseDatePrecision { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "restrictions"
	)]
	public ServiceSpotifyResponseRestrictions Restrictions		   { get; set; } = null;

    [JsonPropertyName(
		name: "resume_point"
	)]
	public ServiceSpotifyResponseResumePoint  ResumePoint		   { get; set; } = null;

    [JsonPropertyName(
		name: "show"
	)]
	public ServiceSpotifyResponseShow		  Show				   { get; set; } = null;

    [JsonPropertyName(
		name: "type"
	)]
	public string							  Type				   { get; set; } = _ = string.Empty;

    [JsonPropertyName(
		name: "uri"
    )]
    public string							  Uri				   { get; set; } = _ = string.Empty;
}