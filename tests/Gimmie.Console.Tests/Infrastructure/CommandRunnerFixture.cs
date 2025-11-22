namespace Gimmie.Console.Tests.Infrastructure;

public class CommandRunnerFixture : IAsyncLifetime
{
    private readonly TextWriter _originalOutput = System.Console.Out;

    public async Task<(int exitCode, string output)> ExecuteCommand(string[] args)
    {
        await using var localWriter = new StringWriter();

        try
        {
            System.Console.SetOut(localWriter);
            int exitCode = await Program.Main(args);
            return (exitCode, localWriter.ToString().Trim());
        }
        finally
        {
            System.Console.SetOut(_originalOutput);
        }
    }

    public async ValueTask DisposeAsync()
    {
        await _originalOutput.DisposeAsync();
        System.Console.SetOut(_originalOutput);
    }

    public ValueTask InitializeAsync() => ValueTask.CompletedTask;
}
