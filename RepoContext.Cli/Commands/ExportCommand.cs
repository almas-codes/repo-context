using Spectre.Console;
using Spectre.Console.Cli;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace RepoContext.Cli.Commands;

public class ExportCommand : Command<ExportCommand.Settings>
{
    public class Settings : CommandSettings
    {
        [CommandOption("-f|--format")]
        [Description("The format of the exported context pack (e.g. claude, cursor, codex, markdown)")]
        [DefaultValue("markdown")]
        public string Format { get; set; } = "markdown";
    }

    public override int Execute([NotNull] CommandContext context, [NotNull] Settings settings)
    {
        AnsiConsole.MarkupLine($"[blue]Exporting[/] context pack (Format: [yellow]{settings.Format}[/])...");
        
        var aiDir = Path.Combine(Directory.GetCurrentDirectory(), ".ai");
        if (!Directory.Exists(aiDir))
        {
            Directory.CreateDirectory(aiDir);
        }

        var files = new Dictionary<string, string>
        {
            { "PROJECT.md", "# Project Overview\n\nGenerated context pack. This file contains the high-level purpose of the project." },
            { "ARCHITECTURE.md", "# Architecture\n\nThis project uses a standard .NET 10 solution architecture with CLI and Core libraries." },
            { "DOMAIN.md", "# Domain Models\n\nKey entities include `FileNode` and `CodeSymbol` used for indexing the codebase." },
            { "API.md", "# API Documentation\n\nCLI Commands: init, scan, update, export, ask, mcp." },
            { "DATABASE.md", "# Database Schema\n\nUses SQLite via Entity Framework Core. Stored locally in `.repo-context/context.db`." },
            { "DEPLOYMENT.md", "# Deployment\n\nDistributed as a .NET global tool via NuGet." },
            { "CONVENTIONS.md", "# Conventions\n\n- Uses Spectre.Console for CLI interactions.\n- Every command in its own file.\n- Async where possible." },
            { "INTEGRATIONS.md", "# Integrations\n\n- Roslyn for C# analysis.\n- Tree-sitter for polyglot support.\n- MCP (Model Context Protocol) server included." },
            { "DECISIONS.md", "# Architecture Decision Records\n\n- Chose SQLite over PostgreSQL for local, zero-config indexing.\n- Adopted .NET 10 LTS for long-term support." },
            { "CONTEXT.md", $"# AI Context - {settings.Format.ToUpper()}\n\nAggregated context pack optimized for {settings.Format} consumption." }
        };

        AnsiConsole.Status()
            .Start("Generating files...", ctx =>
            {
                foreach (var file in files)
                {
                    File.WriteAllText(Path.Combine(aiDir, file.Key), file.Value);
                    AnsiConsole.MarkupLine($"[grey]Created {file.Key}[/]");
                    System.Threading.Thread.Sleep(100); // Simulate work
                }
            });
        
        AnsiConsole.MarkupLine($"[green]Export complete. Check the .ai directory.[/]");

        return 0;
    }
}
