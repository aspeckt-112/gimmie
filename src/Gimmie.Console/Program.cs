using Gimmie.Console.Commands;

GimmeCommand gimmeCommand = new();

await gimmeCommand
    .Parse(args)
    .InvokeAsync();
