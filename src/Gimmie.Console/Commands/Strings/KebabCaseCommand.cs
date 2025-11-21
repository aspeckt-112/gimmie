using Gimmie.Console.Commands.Abstractions;
using Gimmie.Console.Converters;

namespace Gimmie.Console.Commands.Strings;

/// <summary>
/// Converts input text to kebab case.
/// </summary>
internal sealed class KebabCaseCommand()
    : CaseVariantSingleInputCommand(CommandName, CommandDescription, Placeholder)
{
    private const string CommandName = "kebabcase";
    private const string CommandDescription = "Converts input text to kebab case.";
    private const string Placeholder = "kebab-case";

    protected override string Execute(string input) => StringCaseConverter.ToKebabCase(input);
}
