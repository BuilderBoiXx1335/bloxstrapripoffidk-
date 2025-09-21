using System.IO;

public static class ModLoader
{
    public static void LoadMods(string modsDirectory)
    {
        if (!Directory.Exists(modsDirectory)) return;

        string[] modFiles = Directory.GetFiles(modsDirectory);
        foreach (string mod in modFiles)
        {
            Console.WriteLine($"Found mod: {Path.GetFileName(mod)}");
            // You could add DLL injection or file copying here
        }
    }
}

