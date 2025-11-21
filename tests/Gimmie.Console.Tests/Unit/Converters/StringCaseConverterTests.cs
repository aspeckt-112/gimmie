using System.Collections;

namespace Gimmie.Console.Tests.Unit.Converters;

public class StringCaseConverterTests
{
    [Theory]
    [ClassData(typeof(NullOrWhitespaceStringData))]
    public void ToCamelCase_InputIsNullOrWhitespace_ReturnsEmptyString(string? input)
    {
        // Arrange & Act
        string result = StringCaseConverter.ToCamelCase(input!);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    // https://en.toolpage.org/tool/camelcase
    [Theory]
    [ClassData(typeof(CamelCaseConversionData))]
    public void ToCamelCase_ValidInput_ReturnsExpectedResult(string input, string expected)
    {
        // Arrange & Act
        string result = StringCaseConverter.ToCamelCase(input);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [ClassData(typeof(NullOrWhitespaceStringData))]
    public void ToKebabCase_InputIsNullOrWhitespace_ReturnsExpectedResult(string? input)
    {
        // Arrange & Act
        string result = StringCaseConverter.ToKebabCase(input!);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Theory]
    [ClassData(typeof(KebabCaseConversionData))]
    public void ToKebabCase_ValidInput_ReturnsExpectedResult(string input, string expected)
    {
        // Arrange & Act
        string result = StringCaseConverter.ToKebabCase(input);

        // Assert
        Assert.Equal(expected, result);
    }
}

public sealed class NullOrWhitespaceStringData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return [null];
        yield return [""];
        yield return ["   "];
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public sealed class CamelCaseConversionData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return ["hello world", "helloWorld"];
        yield return ["Hello World", "helloWorld"];
        yield return ["hello_world", "helloWorld"];
        yield return ["hello-world", "helloWorld"];
        yield return ["HELLO WORLD", "helloWorld"];
        yield return ["hElLo WoRlD", "helloWorld"];
        yield return ["helloworld", "helloworld"];
        yield return ["HelloWorld", "helloworld"];
        yield return ["  multiple   spaces  here ", "multipleSpacesHere"];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public sealed class KebabCaseConversionData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return ["hello world", "hello-world"];
        yield return ["Hello World", "hello-world"];
        yield return ["hello_world", "hello-world"];
        yield return ["hello-world", "hello-world"];
        yield return ["HELLO WORLD", "hello-world"];
        yield return ["hElLo WoRlD", "hello-world"];
        yield return ["helloworld", "helloworld"];
        yield return ["HelloWorld", "helloworld"];
        yield return ["  multiple   spaces  here ", "multiple-spaces-here"];
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
