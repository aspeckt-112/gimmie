namespace Gimmie.Console.Constants;

/// <summary>
/// The descriptions of the commands available in the Gimmie console application.
/// </summary>
internal static class CommandDescriptions
{
    /// <summary>
    /// The description for the 'guid' command.
    /// </summary>
    internal const string Guid = "Generates a new GUID.";

    /// <summary>
    /// The description for the 'hash' command.
    /// </summary>
    internal const string Hash = "Generates a new hash.";

    /// <summary>
    /// The description for the 'md5' subcommand under the 'hash' command.
    /// </summary>
    internal const string HashMd5 = "Generates an MD5 hash.";

    /// <summary>
    /// The description for the 'sha1' subcommand under the 'hash' command.
    /// </summary>
    internal const string HashSha1 = "Generates a SHA-1 hash.";

    /// <summary>
    /// The description for the 'sha256' subcommand under the 'hash' command.
    /// </summary>
    internal const string HashSha256 = "Generates a SHA-256 hash.";

    /// <summary>
    /// The description for the 'sha512' subcommand under the 'hash' command.
    /// </summary>
    internal const string HashSha512 = "Generates a SHA-512 hash.";

    /// <summary>
    /// The description for the 'sha384' subcommand under the 'hash' command.
    /// </summary>
    internal const string HashSha384 = "Generates a SHA-384 hash.";

    /// <summary>
    /// The description for the 'port' command.
    /// </summary>
    internal const string Port = "Generates a random port number.";

    /// <summary>
    /// The description for the 'base64' command.
    /// </summary>
    internal const string Base64 = "Encode or decode strings using Base64 encoding.";

    /// <summary>
    /// The description for the 'encode' subcommand under the 'base64' command.
    /// </summary>
    internal const string Base64Encode = "Encodes strings using Base64 encoding.";

    /// <summary>
    /// The description for the 'decode' subcommand under the 'base64' command.
    /// </summary>
    internal const string Base64Decode = "Decodes strings from Base64 encoding.";
}
