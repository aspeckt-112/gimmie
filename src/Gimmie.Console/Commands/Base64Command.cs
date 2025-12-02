using System.Text;

namespace Gimmie.Console.Commands;

/// <summary>
/// The 'base64' command encodes and decodes strings using Base64 encoding.
/// </summary>
internal sealed class Base64Command : Command
{
    private const string InputArgumentName = "input";

    public Base64Command() : base(CommandNames.Base64, CommandDescriptions.Base64)
    {
        var inputArgument = new Argument<string>(InputArgumentName)
        {
            Description = "The input string to encode or decode."
        };

        Add(inputArgument);

        Add(CommandOptions.UrlSafe);

        Subcommands.Add(new EncodeCommand());
        Subcommands.Add(new DecodeCommand());
    }

    private abstract class Base64CommandBase : Command
    {
        protected Base64CommandBase(string name, string description) : base(name, description)
        {
            SetAction(result =>
            {
                string? input = result.GetValue<string>(InputArgumentName);

                if (string.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine(MessageConstants.NoInputProvided);
                    return;
                }

                bool urlSafe = result.GetValue<bool>(CommandOptions.UrlSafe.Name);

                string output = ProcessBase64(input, urlSafe);
                System.Console.WriteLine(output);
            });
        }

        protected abstract string ProcessBase64(string input, bool urlSafe);
    }

    private class EncodeCommand() : Base64CommandBase(CommandNames.Base64Encode, CommandDescriptions.Base64Encode)
    {
        protected override string ProcessBase64(string input, bool urlSafe)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            string base64String = Convert.ToBase64String(inputBytes);

            if (urlSafe)
            {
                base64String = base64String.Replace('+', '-').Replace('/', '_').TrimEnd('=');
            }

            return base64String;
        }
    }

    private class DecodeCommand() : Base64CommandBase(CommandNames.Base64Decode, CommandDescriptions.Base64Decode)
    {
        protected override string ProcessBase64(string input, bool urlSafe)
        {
            if (urlSafe)
            {
                input = input.Replace('-', '+').Replace('_', '/');
                switch (input.Length % 4)
                {
                    case 2: input += "=="; break;
                    case 3: input += "="; break;
                }
            }

            try
            {
                byte[] decodedBytes = Convert.FromBase64String(input);
                return Encoding.UTF8.GetString(decodedBytes);
            }
            catch (FormatException)
            {
                System.Console.WriteLine("Error: The provided input is not a valid Base64 string.");
                return string.Empty;
            }
        }
    }
}
