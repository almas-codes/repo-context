using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace RepoContext.Cli.Commands;

public class ScanCommand : Command<ScanCommand.Settings>
{
    public class Settings : CommandSettings { }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
    {
        AnsiConsole.Status()
            .Start("Scanning repository and building index...", ctx =>
            {
                // Simulate some work
                System.Threading.Thread.Sleep(1000);
            });
            
        AnsiConsole.MarkupLine("[green]Scan complete.[/] The local SQLite index is up to date.");
        return 0;
    }
}
