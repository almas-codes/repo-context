using System.ComponentModel.DataAnnotations;

namespace RepoContext.Core.Models;

public class CodeSymbol
{
    [Key]
    public int Id { get; set; }
    public string FilePath { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Kind { get; set; } = string.Empty; // e.g., Class, Method, Interface
    public string Signature { get; set; } = string.Empty;
}
