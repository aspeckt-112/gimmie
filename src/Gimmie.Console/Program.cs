using Gimmie.Console.Commands;

namespace Gimmie.Console;

// ReSharper disable once ClassNeverInstantiated.Global

/// <summary>
/// The main program class for the Gimmie console application.
/// </summary>
/// <remarks>
/// Intentionally not using a top-level statements to facilitate integration testing.
/// </remarks>
public class Program
{
    public static async Task<int> Main(string[] args)
    {
        RootCommand rootCommand = new RootCommand().WithSubcommands(
            new GuidCommand()
        );

        return await rootCommand
            .Parse(args)
            .InvokeAsync();
    }
}
