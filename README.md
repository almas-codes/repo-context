# repo-context

An open-source CLI tool that automatically generates AI-ready context packs for your codebases. 

Whenever you open a large project in Claude Code, Cursor, Copilot, or Codex, the AI often struggles with understanding the architecture, conventions, and database structure. `repo-context` solves this by scanning your project and building a `.ai/` directory full of structured Markdown files that you can feed to your AI assistant.

It even supports the Model Context Protocol (MCP) so agents can query the repository directly.

## Features

- **Scan & Index:** Automatically walks your project and indexes it using Roslyn and Tree-sitter.
- **Export Context:** Generates structured `.ai/` context packs (e.g., `ARCHITECTURE.md`, `CONVENTIONS.md`).
- **Format Support:** Export specifically for `claude`, `cursor`, or `codex`.
- **MCP Server:** Start an MCP stdio server so agents can query the repo dynamically.

## Getting Started

Make sure you have .NET 10 installed.

```bash
# Clone the repo
git clone https://github.com/almas-codes/repo-context.git
cd repo-context

# Build the CLI
dotnet build

# Run it
dotnet run --project RepoContext.Cli -- init
dotnet run --project RepoContext.Cli -- scan
dotnet run --project RepoContext.Cli -- export --format=claude
```

## Stack
- C# & .NET 10
- SQLite for local fast indexing
- Roslyn & Tree-sitter for code analysis
- Spectre.Console for a beautiful CLI

## Contributing

Feel free to open issues or submit pull requests. I built this to solve my own pain point with AI context windows, and I hope it helps you too!

---

## Tags & Keywords for SEO
*AI Codebase Context Generator, Model Context Protocol (MCP) C# .NET, Claude Code Context Tool, Cursor AI Codebase Indexing, Github Copilot Context Pack, Codex Code Understanding, Open-Source Developer Tools C#, Roslyn Syntax Tree Parsing, Tree-sitter Codebase Scanner, Automate AI Context Window, AI Assistant Codebase Integration, .NET 10 Developer CLI, Generate Project Markdown for AI, Software Architecture AI Parser.*
