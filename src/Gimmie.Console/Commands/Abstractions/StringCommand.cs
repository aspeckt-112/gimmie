namespace Gimmie.Console.Commands.Abstractions;

public abstract class StringCommand : Command
{
    protected StringCommand(
        string name,
        string? description = null)
        : base(name, description)
    {
        Argument<string[]> inputTextArgument = new("text")
        {
            Description = "The text to convert.", Arity = ArgumentArity.OneOrMore
        };

        Arguments.Add(inputTextArgument);

        SetAction(parseResult =>
        {
            string[]? parsedArgument = parseResult.GetValue(inputTextArgument);

            if (parsedArgument == null || parsedArgument.Length == 0)
            {
                throw new NotImplementedException("Input text is required.");
            }

            string input = string.Join(" ", parsedArgument);
            System.Console.WriteLine(Convert(input));
        });
    }

    protected abstract string Convert(string input);
}
