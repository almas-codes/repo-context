using Microsoft.EntityFrameworkCore;
using RepoContext.Core.Models;

namespace RepoContext.Core.Data;

public class ContextDb : DbContext
{
    public string DbPath { get; }

    public ContextDb(string basePath)
    {
        var folder = Path.Combine(basePath, ".repo-context");
        if (!Directory.Exists(folder))
        {
            Directory.CreateDirectory(folder);
        }
        DbPath = Path.Combine(folder, "context.db");
    }

    public DbSet<FileNode> Files { get; set; } = null!;
    public DbSet<CodeSymbol> Symbols { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}
