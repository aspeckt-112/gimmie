using Gimmie.Console.Commands.Abstractions;

namespace Gimmie.Console.Commands;

public class LowercaseCommand() : StringCommand(CommandName, CommandDescription)
{
    private const string CommandName = "lowercase";
    private const string CommandDescription = "Converts input text to lowercase.";

    protected override string Convert(string input) => input.ToLowerInvariant();
}
