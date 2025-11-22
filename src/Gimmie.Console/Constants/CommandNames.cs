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
}
