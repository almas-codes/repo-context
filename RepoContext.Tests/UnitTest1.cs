namespace RepoContext.Tests;

public class BasicTests
{
    [Fact]
    public void Export_CreatesAiDirectory()
    {
        var aiDir = Path.Combine(Directory.GetCurrentDirectory(), ".ai_test");
        if (Directory.Exists(aiDir))
            Directory.Delete(aiDir, true);

        Directory.CreateDirectory(aiDir);
        File.WriteAllText(Path.Combine(aiDir, "PROJECT.md"), "test");

        Assert.True(Directory.Exists(aiDir));
        Assert.True(File.Exists(Path.Combine(aiDir, "PROJECT.md")));

        Directory.Delete(aiDir, true);
    }
}
