using System.Text;
using System.Security.Cryptography;

namespace Gimmie.Console.Commands;

public sealed class HashCommand : Command
{
    private const string InputArgumentName = "input";

    public HashCommand() : base(CommandNames.Hash, CommandDescriptions.Hash)
    {
        var inputArgument = new Argument<string>(InputArgumentName)
        {
            Description = "The input string to hash."
        };

        Add(inputArgument);
        Subcommands.Add(new Md5Command());
        Subcommands.Add(new Sha1Command());
    }

    private abstract class HashCommandBase : Command
    {
        protected HashCommandBase(string name, string description) : base(name, description)
        {
            SetAction(result =>
            {
                string? input = result.GetValue<string>(InputArgumentName);

                if (string.IsNullOrWhiteSpace(input))
                {
                    System.Console.WriteLine(MessageConstants.NoInputProvided);
                    return;
                }

                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = ComputeHash(inputBytes);
                string hashString = Convert.ToHexStringLower(hashBytes);

                System.Console.WriteLine(hashString);
            });
        }

        protected abstract byte[] ComputeHash(byte[] inputBytes);
    }

    private class Md5Command : HashCommandBase
    {
        public Md5Command() : base(CommandNames.HashMd5, CommandDescriptions.HashMd5)
        {
        }

        protected override byte[] ComputeHash(byte[] inputBytes) => MD5.HashData(inputBytes);
    }

    private class Sha1Command : HashCommandBase
    {
        public Sha1Command() : base(CommandNames.HashSha1, CommandDescriptions.HashSha1)
        {
        }

        protected override byte[] ComputeHash(byte[] inputBytes) => SHA1.HashData(inputBytes);
    }
}
