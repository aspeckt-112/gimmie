using Gimmie.Console.Commands.Abstractions;
using Gimmie.Console.Converters;

namespace Gimmie.Console.Commands.Strings;

internal sealed class CamelCaseCommand() : SingleInputCommand(CommandName, CommandDescription)
{
    private const string CommandName = "camelcase";
    private const string CommandDescription = "Converts input text to camel case.";

    protected override string Execute(string input) => StringCaseConverter.ToCamelCase(input);
}
