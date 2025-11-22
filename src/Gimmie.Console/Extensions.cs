namespace Gimmie.Console;

internal static class Extensions
{
    extension(RootCommand rootCommand)
    {
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
