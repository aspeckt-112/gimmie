using Gimmie.Console.Constants;

namespace Gimmie.Console.Commands;

/// <summary>
/// The 'guid' command generates a new GUID.
/// </summary>
public sealed class GuidCommand : Command
{
    public GuidCommand() : base(CommandNames.Guid, CommandDescriptions.Guid)
    {
        SetAction(_ =>
        {
            System.Console.WriteLine(Guid.NewGuid());
        });
    }
}
