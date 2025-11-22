namespace Gimmie.Console.Tests.Integration.Commands;

[Collection("Sequential Console Collection")]
public class HashCommandTests
{
    private const string HelloWorldInput = "Hello, World!";

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
        const string expectedHash = "65a8e27d8879283831b664bd8b7f0ad4";
        string[] args = [CommandNames.Hash, HelloWorldInput, CommandNames.HashMd5];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(expectedHash, result);
    }

    [Fact]
    public async Task HashCommand_Sha1SubcommandNoInput_ShouldDisplayNoInputMessage()
    {
        // Arrange
        string[] args = [CommandNames.Hash, CommandNames.HashSha1];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(MessageConstants.NoInputProvided, result);
    }

    [Fact]
    public async Task HashCommand_Sha1SubcommandWithInput_ShouldDisplaySha1Hash()
    {
        // Arrange
        const string expectedHash = "0a0a9f2a6772942557ab5355d76af442f8f65e01";
        string[] args = [CommandNames.Hash, HelloWorldInput, CommandNames.HashSha1];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(expectedHash, result);
    }

    [Fact]
    public async Task HashCommand_Sha256SubcommandNoInput_ShouldDisplayNoInputMessage()
    {
        // Arrange
        string[] args = [CommandNames.Hash, CommandNames.HashSha256];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(MessageConstants.NoInputProvided, result);
    }

    [Fact]
    public async Task HashCommand_Sha256SubcommandWithInput_ShouldDisplaySha256Hash()
    {
        // Arrange
        const string expectedHash = "dffd6021bb2bd5b0af676290809ec3a53191dd81c7f70a4b28688a362182986f";
        string[] args = [CommandNames.Hash, HelloWorldInput, CommandNames.HashSha256];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(expectedHash, result);
    }

    [Fact]
    public async Task HashCommand_Sha224SubcommandWithNoInput_ShouldDisplayNoInputMessage()
    {
        // Arrange
        string[] args = [CommandNames.Hash, CommandNames.HashSha224];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(MessageConstants.NoInputProvided, result);
    }

    [Fact]
    public async Task HashCommand_Sha224SubcommandWithInput_ShouldDisplaySha224Hash()
    {
        // Arrange
        const string expectedHash = "dffd6021bb2bd5b0af676290809ec3a53191dd81c7f70a4b28688a36";
        string[] args = [CommandNames.Hash, HelloWorldInput, CommandNames.HashSha224];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(expectedHash, result);
    }

    [Fact]
    public async Task HashCommand_Sha512SubcommandWithNoInput_ShouldDisplayNoInputMessage()
    {
        // Arrange
        string[] args = [CommandNames.Hash, CommandNames.HashSha512];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(MessageConstants.NoInputProvided, result);
    }

    [Fact]
    public async Task HashCommand_Sha512SubcommandWithInput_ShouldDisplaySha512Hash()
    {
        // Arrange
        const string expectedHash =
            "374d794a95cdcfd8b35993185fef9ba368f160d8daf432d08ba9f1ed1e5abe6cc69291e0fa2fe0006a52570ef18c19def4e617c33ce52ef0a6e5fbe318cb0387";

        string[] args = [CommandNames.Hash, HelloWorldInput, CommandNames.HashSha512];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(expectedHash, result);
    }

    [Fact]
    public async Task HashCommand_Sha384SubcommandWithNoInput_ShouldDisplayNoInputMessage()
    {
        // Arrange
        string[] args = [CommandNames.Hash, CommandNames.HashSha384];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(MessageConstants.NoInputProvided, result);
    }

    [Fact]
    public async Task HashCommand_Sha384SubcommandWithInput_ShouldDisplaySha384Hash()
    {
        // Arrange
        const string expectedHash =
            "5485cc9b3365b4305dfb4e8337e0a598a574f8242bf17289e0dd6c20a3cd44a089de16ab4ab308f63e44b1170eb5f515";

        string[] args = [CommandNames.Hash, HelloWorldInput, CommandNames.HashSha384];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(expectedHash, result);
    }
}
