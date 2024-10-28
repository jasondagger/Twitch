
namespace Twitch.Core.Tools;

using System.Text.Json;

internal static class Json
{
    internal static TObject Deserialize<TObject>(
        string json
    )
    {
        return _ = JsonSerializer.Deserialize<TObject>(
            json:    _ = json,
            options: _ = Json.JsonSerializerOptions
        );
    }

    internal static string Serialize<TObject>(
        TObject @object
    )
    {
        return _ = JsonSerializer.Serialize(
            value:   _ = @object,
            options: _ = Json.JsonSerializerOptions
        );
    }

    private static JsonSerializerOptions JsonSerializerOptions { get; } = new()
    {
        IncludeFields = _ = true,
    };
}