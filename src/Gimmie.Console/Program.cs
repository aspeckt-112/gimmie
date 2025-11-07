using Gimmie.Console.Commands;

RootCommand rootCommand = new();

rootCommand.Subcommands.Add(new GuidCommand());
rootCommand.Subcommands.Add(new UppercaseCommand());

await rootCommand
    .Parse(args)
    .InvokeAsync();
