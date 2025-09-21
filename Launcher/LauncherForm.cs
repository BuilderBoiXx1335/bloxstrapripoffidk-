using System.Drawing;
using System.Windows.Forms;

public class LauncherForm : Form
{
    private Theme theme;

    public LauncherForm(Theme theme)
    {
        this.theme = theme;
        this.Text = "BloxstrapRipoffIDK";
        this.Size = new Size(400, 300);
        this.BackColor = ColorTranslator.FromHtml(theme.BackgroundColor);

        var launchButton = new Button()
        {
            Text = "Launch Roblox",
            ForeColor = ColorTranslator.FromHtml(theme.TextColor),
            BackColor = ColorTranslator.FromHtml(theme.AccentColor),
            Location = new Point(130, 100),
            Size = new Size(140, 40)
        };
        launchButton.Click += (s, e) => LaunchRoblox();

        this.Controls.Add(launchButton);
    }

    private void LaunchRoblox()
    {
        MessageBox.Show("Launching Roblox... (stub)");
        // You could call Roblox executable here
    }
}
