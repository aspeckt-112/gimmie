namespace Gimmie.Console.Tests.Infrastructure;

/// <summary>
/// This class defines a collection for console tests that should be run sequentially to avoid
/// interference due to shared console output.
/// </summary>
[CollectionDefinition("Sequential Console Collection")]
#pragma warning disable CA1711
public class ConsoleCollection : ICollectionFixture<CommandRunnerFixture>;
#pragma warning restore CA1711
