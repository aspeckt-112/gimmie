namespace Gimmie.Console.Constants;

/// <summary>
/// The descriptions of the commands available in the Gimmie console application.
/// </summary>
internal static class CommandDescriptions
{
    /// <summary>
    /// The description for the 'guid' command.
    /// </summary>
    public const string Guid = "Generates a new GUID.";

    /// <summary>
    /// The description for the 'hash' command.
    /// </summary>
    public const string Hash = "Generates a new hash.";

    /// <summary>
    /// The description for the 'md5' subcommand under the 'hash' command.
    /// </summary>
    public const string HashMd5 = "Generates an MD5 hash.";

    /// <summary>
    /// The description for the 'sha1' subcommand under the 'hash' command.
    /// </summary>
    public const string HashSha1 = "Generates a SHA-1 hash.";
}
