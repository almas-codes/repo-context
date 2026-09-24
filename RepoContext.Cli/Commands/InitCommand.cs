using Spectre.Console;
using Spectre.Console.Cli;
using System.Diagnostics.CodeAnalysis;

namespace RepoContext.Cli.Commands;

public class InitCommand : Command<InitCommand.Settings>
{
    public class Settings : CommandSettings { }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
    {
        AnsiConsole.MarkupLine("[green]Initialized[/] repo-context in the current directory.");
        return 0;
    }
}
