namespace Gimmie.Console.Commands;

public class GuidCommand : Command
{
    private const string CommandName = "guid";
    private const string CommandDescription = "Generates a new GUID.";

    public GuidCommand() : base(CommandName, CommandDescription)
    {
        SetAction(_ =>
        {
            System.Console.WriteLine(Guid.NewGuid());
        });
    }
}
