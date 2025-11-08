using Gimmie.Console.Commands.Abstractions;

namespace Gimmie.Console.Commands;

internal sealed class LengthCommand() : SingleInputCommand(CommandName, CommandDescription)
{
    private const string CommandName = "length";
    private const string CommandDescription = "Calculates the length of a given string.";

    protected override string Execute(string input) => input.Length.ToString();
}
