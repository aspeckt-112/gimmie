namespace Gimmie.Console.Tests.Integration.Commands;

[Collection("Sequential Console Collection")]
public class Base64CommandTests
{
    private const string HelloWorldInput = "Hello, World!";
    private const string HelloWorldBase64Standard = "SGVsbG8sIFdvcmxkIQ==";
    private const string HelloWorldBase64UrlSafe = "SGVsbG8sIFdvcmxkIQ";

    private readonly CommandRunnerFixture _fixture;

    public Base64CommandTests(CommandRunnerFixture fixture)
    {
        _fixture = fixture;
    }

    [Fact]
    public async Task Base64Command_EncodeSubcommandNoInput_ShouldDisplayNoInputMessage()
    {
        // Arrange
        string[] args = [CommandNames.Base64, CommandNames.Base64Encode];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(MessageConstants.NoInputProvided, result);
    }

    [Fact]
    public async Task Base64Command_EncodeSubcommandWithInput_ShouldDisplayBase64EncodedString()
    {
        // Arrange
        string[] args = [CommandNames.Base64, HelloWorldInput, CommandNames.Base64Encode];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(HelloWorldBase64Standard, result);
    }

    [Fact]
    public async Task Base64Command_EncodeSubcommandWithInputUrlSafe_ShouldDisplayBase64UrlSafeEncodedString()
    {
        // Arrange
        string[] args = [CommandNames.Base64, HelloWorldInput, CommandNames.Base64Encode, CommandOptions.UrlSafe.Name];

        // Act
        (int exitCode, string result) = await _fixture.ExecuteCommand(args);

        // Assert
        Assert.Equal(0, exitCode);
        Assert.Equal(HelloWorldBase64UrlSafe, result);
    }
}
