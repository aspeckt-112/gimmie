using Gimmie.Console.Commands.Abstractions;

namespace Gimmie.Console.Commands.Strings;

internal sealed class UppercaseCommand() : BaseStringCommand(CommandName, CommandDescription)
{
    private const string CommandName = "uppercase";
    private const string CommandDescription = "Converts input text to uppercase.";

    protected override string Execute(string input) => input.ToUpperInvariant();
}
