using Spectre.Console.Cli;
using RepoContext.Cli.Commands;

namespace RepoContext.Cli;

public class Program
{
    public static int Main(string[] args)
    {
        var app = new CommandApp();
        app.Configure(config =>
        {
            config.SetApplicationName("repo-context");

            config.AddCommand<InitCommand>("init")
                .WithDescription("Initialize a new repo-context configuration in the current directory.");

            config.AddCommand<ScanCommand>("scan")
                .WithDescription("Scan the repository and update the context index.");

            config.AddCommand<UpdateCommand>("update")
                .WithDescription("Incrementally scan the repository based on changes.");

            config.AddCommand<ExportCommand>("export")
                .WithDescription("Export the indexed context to the .ai/ directory.");

            config.AddCommand<AskCommand>("ask")
                .WithDescription("Ask a question about the repository.");

            config.AddCommand<McpCommand>("mcp")
                .WithDescription("Start the MCP stdio server.");
        });

        return app.Run(args);
    }
}
