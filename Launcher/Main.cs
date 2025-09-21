using System;
using System.Windows.Forms;

class Program
{
    [STAThread]
    static void Main()
    {
        // Load settings
        Settings.Load("settings.json");

        // Load theme
        var theme = ThemeManager.LoadTheme("Assets/Themes/dark.json");

        // Start Discord Rich Presence
        RichPresence.Init();

        // Load mods
        ModLoader.LoadMods("Mods");

        // Launch UI
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new LauncherForm(theme));
    }
}

