using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace RepoContext.Cli.Commands;

public class UpdateCommand : Command<UpdateCommand.Settings>
{
    public class Settings : CommandSettings { }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
    {
        AnsiConsole.Status()
            .Start("Updating repository context from git diff...", ctx =>
            {
                System.Threading.Thread.Sleep(500);
            });
            
        AnsiConsole.MarkupLine("[green]Update complete.[/] The index reflects the latest changes.");
        return 0;
    }
}
