namespace Gimmie.Console.Tests.Integration.Commands;

[Collection("Sequential Console Collection")]
public class HashCommandTests
{
    private readonly CommandRunnerFixture _fixture;

    public HashCommandTests(CommandRunnerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task HashCommand_Md5SubcommandNoInput_ShouldDisplayNoInputMessage()
    {
        // Arrange
        string[] args = [CommandNames.Hash, CommandNames.HashMd5];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(MessageConstants.NoInputProvided, result);
    }

    [Fact]
    public async Task HashCommand_Md5SubcommandWithInput_ShouldDisplayMd5Hash()
    {
        // Arrange
        string input = "Hello, World!";
        const string expectedHash = "65a8e27d8879283831b664bd8b7f0ad4";
        string[] args = [CommandNames.Hash, input, CommandNames.HashMd5];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(expectedHash, result);
    }
}
