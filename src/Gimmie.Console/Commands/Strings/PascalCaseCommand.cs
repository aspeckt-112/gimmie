using Gimmie.Console.Commands.Abstractions;
using Gimmie.Console.Converters;

namespace Gimmie.Console.Commands.Strings;

internal sealed class PascalCaseCommand() : SingleInputCommand(CommandName, CommandDescription)
{
    private const string CommandName = "pascalcase";
    private const string CommandDescription = "Converts input text to pascal case.";

    protected override string Execute(string input) => StringCaseConverter.ToPascalCase(input);
}
