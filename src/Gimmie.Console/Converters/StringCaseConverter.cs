using System.Text;

namespace Gimmie.Console.Converters;

internal static class StringCaseConverter
{
    internal static string ToPascalCase(string input) => ToPascalOrCamelCase(input, capitalizeFirst: true);

    internal static string ToCamelCase(string input) => ToPascalOrCamelCase(input, capitalizeFirst: false);

    internal static string ToSnakeCase(string input) => ToSeparatedCase(input, '_');

    internal static string ToKebabCase(string input) => ToSeparatedCase(input, '-');

    private static string ToPascalOrCamelCase(string input, bool capitalizeFirst)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return string.Empty;
        }

        var sb = new StringBuilder();

        bool capitalizeNext = capitalizeFirst;
        int len = input.Length;

        for (int i = 0; i < len; i++)
        {
            char c = input[i];

            if (IsSeparatorChar(c))
            {
                capitalizeNext = true;
            }
            else if (capitalizeNext)
            {
                sb.Append(char.ToUpperInvariant(c));
                capitalizeNext = false;
            }
            else
            {
                sb.Append(char.ToLowerInvariant(c));
            }
        }

        if (!capitalizeFirst && sb.Length > 0)
        {
            sb[0] = char.ToLowerInvariant(sb[0]);
        }

        return sb.ToString();
    }

    private static string ToSeparatedCase(string input, char separator)
    {
        // TODO This method doesn't handle camelCase or PascalCase input properly.
        // When converting "HelloWorld" to snake_case, it won't insert separators between capital letters.
        // The method needs to detect case transitions (lowercase to uppercase) and insert separators accordingly.
        if (string.IsNullOrWhiteSpace(input))
        {
            return string.Empty;
        }

        var sb = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (IsSeparatorChar(c))
            {
                if (sb.Length > 0 && sb[^1] != separator)
                {
                    sb.Append(separator);
                }
            }

            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    private static bool IsSeparatorChar(char c) => c is ' ' or '-' or '_';
}
