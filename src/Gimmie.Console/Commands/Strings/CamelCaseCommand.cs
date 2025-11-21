using Gimmie.Console.Commands.Abstractions;
using Gimmie.Console.Converters;

namespace Gimmie.Console.Commands.Strings;

/// <summary>
/// Converts input text to camel case.
/// </summary>
/// <remarks>
/// It's definition of camel case is that the first letter of the resulting string is lowercase,
/// aka "lower camel case". For "upper camel case", see <see cref="PascalCaseCommand"/>.
/// </remarks>
internal sealed class CamelCaseCommand() : SingleInputCommand(CommandName, CommandDescription)
{
    private const string CommandName = "camelcase";
    private const string CommandDescription = "Converts input text to camel case.";

    protected override string Execute(string input) => StringCaseConverter.ToCamelCase(input);
}
