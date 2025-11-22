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
        Subcommands.Add(new Sha256Command());
        Subcommands.Add(new Sha224Command());
        Subcommands.Add(new Sha512Command());
        Subcommands.Add(new Sha384Command());
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

    private class Md5Command() : HashCommandBase(CommandNames.HashMd5, CommandDescriptions.HashMd5)
    {
        protected override byte[] ComputeHash(byte[] inputBytes) => MD5.HashData(inputBytes);
    }

    private class Sha1Command() : HashCommandBase(CommandNames.HashSha1, CommandDescriptions.HashSha1)
    {
        protected override byte[] ComputeHash(byte[] inputBytes) => SHA1.HashData(inputBytes);
    }

    private class Sha256Command() : HashCommandBase(CommandNames.HashSha256, CommandDescriptions.HashSha256)
    {
        protected override byte[] ComputeHash(byte[] inputBytes) => SHA256.HashData(inputBytes);
    }

    private class Sha224Command() : HashCommandBase(CommandNames.HashSha224, CommandDescriptions.HashSha224)
    {
        protected override byte[] ComputeHash(byte[] inputBytes)
        {
            Span<byte> fullHash = stackalloc byte[32];
            SHA256.HashData(inputBytes, fullHash);
            return fullHash[..28].ToArray();
        }
    }

    private class Sha512Command() : HashCommandBase(CommandNames.HashSha512, CommandDescriptions.HashSha512)
    {
        protected override byte[] ComputeHash(byte[] inputBytes) => SHA512.HashData(inputBytes);
    }

    private class Sha384Command() : HashCommandBase(CommandNames.HashSha384, CommandDescriptions.HashSha384)
    {
        protected override byte[] ComputeHash(byte[] inputBytes) => SHA384.HashData(inputBytes);
    }
}
