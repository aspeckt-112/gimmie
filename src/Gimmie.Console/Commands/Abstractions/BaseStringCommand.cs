namespace Gimmie.Console.Commands.Abstractions;

internal abstract class BaseStringCommand : Command
{
    private const string TextArgumentName = "text";

    protected BaseStringCommand(
        string name,
        string? description = null)
        : base(name, description)
    {
        Argument<string[]> inputTextArgument = new(TextArgumentName)
        {
            Description = "The text to convert.", Arity = ArgumentArity.OneOrMore
        };

        Add(inputTextArgument);

        SetAction(parseResult =>
        {
            string[]? parsedArgument = parseResult.GetValue(inputTextArgument);

            if (parsedArgument == null || parsedArgument.Length == 0)
            {
                throw new NotImplementedException("Input text is required.");
            }

            string input = string.Join(" ", parsedArgument);

            System.Console.WriteLine(InputTransformer is not null
                ? Execute(InputTransformer(parseResult, input))
                : Execute(input));
        });
    }

    protected virtual Func<ParseResult, string, string>? InputTransformer => null;

    protected abstract string Execute(string input);
}
