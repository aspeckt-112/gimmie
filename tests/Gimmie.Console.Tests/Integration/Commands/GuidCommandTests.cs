namespace Gimmie.Console.Tests.Integration.Commands;

[Collection("Sequential Console Collection")]
public class GuidCommandTests
{
    private readonly CommandRunnerFixture _fixture;

    public GuidCommandTests(CommandRunnerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task GuidCommand_ShouldGenerateGuid()
    {
        // Arrange
        string[] args = [CommandNames.Guid];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.True(Guid.TryParse(result, out _), "The output is not a valid GUID.");
    }
}
