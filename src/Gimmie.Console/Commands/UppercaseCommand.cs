using Gimmie.Console.Commands.Abstractions;

namespace Gimmie.Console.Commands;

public class UppercaseCommand() : StringCommand(CommandName, CommandDescription)
{
    private const string CommandName = "uppercase";
    private const string CommandDescription = "Converts input text to uppercase.";

    protected override string Convert(string input) => input.ToUpperInvariant();
}
