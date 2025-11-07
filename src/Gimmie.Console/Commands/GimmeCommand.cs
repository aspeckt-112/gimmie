namespace Gimmie.Console.Commands;

public class GimmeCommand : RootCommand
{
    public GimmeCommand()
    {
        Description = "The main command for Gimmie.";
        Subcommands.Add(new GuidCommand());
    }
}
