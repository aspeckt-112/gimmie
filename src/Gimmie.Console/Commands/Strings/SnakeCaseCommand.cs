using Gimmie.Console.Commands.Abstractions;
using Gimmie.Console.Converters;

namespace Gimmie.Console.Commands.Strings;

internal sealed class SnakeCaseCommand() : CaseVariantSingleInputCommand(CommandName, CommandDescription, Placeholder)
{
    private const string CommandName = "snakecase";
    private const string CommandDescription = "Converts input text to snake case.";
    private const string Placeholder = "snake_case";

    protected override string Execute(string input) => StringCaseConverter.ToSnakeCase(input);
}
