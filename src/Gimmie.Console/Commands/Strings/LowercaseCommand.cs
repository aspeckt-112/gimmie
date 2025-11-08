using Gimmie.Console.Commands.Abstractions;

namespace Gimmie.Console.Commands.Strings;

internal sealed class LowercaseCommand() : SingleInputCommand(CommandName, CommandDescription)
{
    private const string CommandName = "lowercase";
    private const string CommandDescription = "Converts input text to lowercase.";

    protected override string Execute(string input) => input.ToLowerInvariant();
}
