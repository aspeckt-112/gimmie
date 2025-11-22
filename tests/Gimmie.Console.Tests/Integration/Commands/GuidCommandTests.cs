namespace Gimmie.Console.Tests.Integration.Commands;

public class GuidCommandTests
{
    [Fact]
    public async Task GuidCommand_ShouldGenerateGuid()
    {
        // Arrange
        StringWriter output = new();
        System.Console.SetOut(output);

        string[] args = [CommandNames.Guid];

        // Act
        int exitCode = await Program.Main(args);

        // Assert
        Assert.Equal(0, exitCode);
        string result = output.ToString().Trim();
        Assert.True(Guid.TryParse(result, out _), "The output is not a valid GUID.");
    }
}
