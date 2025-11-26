namespace Gimmie.Console.Tests.Integration.Commands;

[Collection("Sequential Console Collection")]
public class PortCommandTests
{
    private readonly CommandRunnerFixture _fixture;

    public PortCommandTests(CommandRunnerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task PortCommand_ShouldGenerateValidPort()
    {
        const int iterations = 1000;

        for (int i = 0; i < iterations; i++)
        {
            // Arrange
            string[] args = [CommandNames.Port];

            // Act
            (int exitCode, string result) = await _fixture.ExecuteCommand(args);

            // Assert
            Assert.Equal(0, exitCode);

            bool parsed = int.TryParse(result.Trim(), out int generatedPort);
            Assert.True(parsed, $"Iteration {i}: result '{result}' is not an integer.");
            Assert.InRange(generatedPort, 1024, 65535);
        }
    }
}
