namespace Gimmie.Console.Commands.Abstractions;

internal abstract class CaseVariantBaseStringCommand : BaseStringCommand
{
    private const string UppercaseOptionName = "--uppercase";
    private const string UppercaseOptionAlias = "-u";

    protected CaseVariantBaseStringCommand(
        string name,
        string description,
        string placeholder)
        : base(name, description)
    {
        Option<bool> uppercaseOption = new(UppercaseOptionName, UppercaseOptionAlias)
        {
            Description = $"Convert to uppercase ({placeholder.ToUpperInvariant()}) instead of lowercase ({placeholder.ToUpperInvariant()}).",
        };

        Add(uppercaseOption);
    }

    protected override Func<ParseResult, string, string> InputTransformer => (parseResult, input) =>
    {
        bool isUppercase = parseResult.GetValue<bool>(UppercaseOptionName);
        return isUppercase ? input.ToUpperInvariant() : input.ToLowerInvariant();
    };
}
