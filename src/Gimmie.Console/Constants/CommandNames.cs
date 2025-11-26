using System.Diagnostics.CodeAnalysis;

namespace Gimmie.Console.Constants;

/// <summary>
/// The names of the commands available in the Gimmie console application.
/// </summary>
[SuppressMessage("Naming", "CA1720:Identifier contains type name", Justification = "The name 'Guid' is appropriate for the command that generates GUIDs.")]
public static class CommandNames
{
    /// <summary>
    /// The 'guid' command.
    /// </summary>
    public const string Guid = "guid";

    /// <summary>
    /// The 'hash' command.
    /// </summary>
    public const string Hash = "hash";

    /// <summary>
    /// The 'md5' subcommand under the 'hash' command.
    /// </summary>
    public const string HashMd5 = "md5";

    /// <summary>
    /// The 'sha1' subcommand under the 'hash' command.
    /// </summary>
    public const string HashSha1 = "sha1";

    /// <summary>
    /// The 'sha256' subcommand under the 'hash' command.
    /// </summary>
    public const string HashSha256 = "sha256";

    /// <summary>
    /// The 'sha512' subcommand under the 'hash' command.
    /// </summary>
    public const string HashSha512 = "sha512";

    /// <summary>
    /// The 'sha384' subcommand under the 'hash' command.
    /// </summary>
    public const string HashSha384 = "sha384";

    /// <summary>
    /// The 'port' command.
    /// </summary>
    public const string Port = "port";
}
