using DiscordRPC;

public static class RichPresence
{
    private static DiscordRpcClient client;

    public static void Init()
    {
        client = new DiscordRpcClient("YOUR_DISCORD_APP_ID");
        client.Initialize();

        client.SetPresence(new RichPresence()
        {
            Details = "Playing Roblox",
            State = "Using Custom Launcher",
            Assets = new Assets()
            {
                LargeImageKey = "roblox",
                LargeImageText = "Roblox"
            }
        });
    }

    public static void Shutdown()
    {
        client.Dispose();
    }
}

