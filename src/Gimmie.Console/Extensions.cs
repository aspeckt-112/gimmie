namespace Gimmie.Console;

/// <summary>
/// Extension methods for internal use.
/// </summary>
internal static class Extensions
{
    /// <summary>
    /// Extensions for <see cref="RootCommand"/>
    /// </summary>
    /// <param name="rootCommand">The root command.</param>
    extension(RootCommand rootCommand)
    {
        /// <summary>
        /// Adds subcommands to the root command.
        /// </summary>
        /// <param name="subcommands">The subcommands to add.</param>
        /// <returns>The root command with added subcommands.</returns>
        internal RootCommand WithSubcommands(params Command[] subcommands)
        {
            foreach (Command subcommand in subcommands)
            {
                rootCommand.Subcommands.Add(subcommand);
            }

            return rootCommand;
        }
    }
}
