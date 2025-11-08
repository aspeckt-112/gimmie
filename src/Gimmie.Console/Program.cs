using Gimmie.Console.Commands;
using Gimmie.Console.Commands.Strings;

RootCommand rootCommand = new();

AddGuidCommand(rootCommand);
AddStringCommands(rootCommand);
AddLengthCommand(rootCommand);

return await rootCommand
    .Parse(args)
    .InvokeAsync();

static void AddGuidCommand(RootCommand rootCommand)
{
    rootCommand.Subcommands.Add(new GuidCommand());
}

static void AddStringCommands(RootCommand rootCommand)
{
    Command stringCommand = new("string", "String manipulation commands");
    rootCommand.Subcommands.Add(stringCommand);

    stringCommand.Subcommands.Add(new UppercaseCommand());
    stringCommand.Subcommands.Add(new LowercaseCommand());
    stringCommand.Subcommands.Add(new CamelCaseCommand());
    stringCommand.Subcommands.Add(new PascalCaseCommand());
    stringCommand.Subcommands.Add(new SnakeCaseCommand());
    stringCommand.Subcommands.Add(new KebabCaseCommand());
}

static void AddLengthCommand(RootCommand rootCommand)
{
    rootCommand.Subcommands.Add(new LengthCommand());
}
