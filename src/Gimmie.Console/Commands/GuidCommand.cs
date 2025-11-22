using Gimmie.Console.Constants;

namespace Gimmie.Console.Commands;

/// <summary>
/// The 'guid' command generates a new GUID.
/// </summary>
public sealed class GuidCommand : Command
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GuidCommand"/> class.
    /// </summary>
    /// <returns>A new instance of the <see cref="GuidCommand"/> class.</returns>
    public GuidCommand() : base(CommandNames.Guid, CommandDescriptions.Guid)
    {
        SetAction(_ =>
        {
            System.Console.WriteLine(Guid.NewGuid());
        });
    }
}
