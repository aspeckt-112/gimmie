namespace Gimmie.Console.Constants;

/// <summary>
/// The names of the command options available in the Gimmie console application.
/// </summary>
public static class CommandOptions
{
    public static readonly Option<bool> UrlSafe = new("--url-safe", "-u")
    {
        Description = "Encode or decode using URL-safe Base64. Default is standard Base64.",
        Required = false,
        Recursive = true
    };
}
