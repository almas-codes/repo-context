using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace RepoContext.Cli.Commands;

public class AskCommand : Command<AskCommand.Settings>
{
    public class Settings : CommandSettings
    {
        [CommandArgument(0, "<QUESTION>")]
        [Description("The question to ask about the repository.")]
        public string Question { get; set; } = string.Empty;
    }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
    {
        AnsiConsole.MarkupLine($"[cyan]Question:[/] {settings.Question}");
        
        AnsiConsole.Status()
            .Start("Querying local index and calling LLM...", ctx =>
            {
                System.Threading.Thread.Sleep(1500);
            });

        // Mock answer for now
        var panel = new Panel("Authentication is handled via JWT tokens using the `Microsoft.AspNetCore.Authentication.JwtBearer` package. The token validation logic resides in `AuthService.cs`.")
        {
            Header = new PanelHeader("Answer"),
            Border = BoxBorder.Rounded,
            Padding = new Padding(2, 1, 2, 1)
        };
        
        AnsiConsole.Write(panel);
        
        return 0;
    }
}
