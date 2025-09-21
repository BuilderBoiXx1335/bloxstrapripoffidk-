using System.IO;
using System.Text.Json;

public class SettingsData
{
    public string SelectedTheme { get; set; } = "dark.json";
}

public static class Settings
{
    public static SettingsData Current { get; private set; }

    public static void Load(string path)
    {
        if (!File.Exists(path))
        {
            Current = new SettingsData();
            Save(path);
        }
        else
        {
            string json = File.ReadAllText(path);
            Current = JsonSerializer.Deserialize<SettingsData>(json);
        }
    }

    public static void Save(string path)
    {
        string json = JsonSerializer.Serialize(Current, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(path, json);
    }
}

