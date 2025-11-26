namespace Gimmie.Console.Commands;

/// <summary>
/// The 'port' command generates a random port number.
/// </summary>
/// <remarks>
/// The port number is generated within the valid range for TCP/UDP ports (1024-65535).
/// </remarks>
internal sealed class PortCommand : Command
{
    public PortCommand() : base(CommandNames.Port, CommandDescriptions.Port)
    {
        SetAction(_ =>
        {
            int portNumber = Random.Shared.Next(1024, 65536);
            System.Console.WriteLine(portNumber);
        });
    }
}
