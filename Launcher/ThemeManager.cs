using System.IO;
using System.Text.Json;

public class Theme
{
    public string BackgroundColor { get; set; }
    public string TextColor { get; set; }
    public string AccentColor { get; set; }
}

public static class ThemeManager
{
    public static Theme LoadTheme(string path)
    {
        if (!File.Exists(path)) return null;
        string json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<Theme>(json);
    }
}

