using System;
using System.ComponentModel.DataAnnotations;

namespace RepoContext.Core.Models;

public class FileNode
{
    [Key]
    public string Path { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Extension { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Hash { get; set; } = string.Empty;
    public DateTime LastModified { get; set; }
}
