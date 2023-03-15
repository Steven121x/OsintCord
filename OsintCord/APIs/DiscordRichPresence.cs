using DiscordRPC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsintCord.APIs
{
    class DiscordRichPresence
    {
        public static DiscordRpcClient client;
        public static Timestamps rpctimestamp { get; set; }
        private static RichPresence presence;
        public static void InitializeRPC()
        {
            client = new DiscordRpcClient("1085454070455742474");
            client.Initialize();
            Button[] buttons = { new Button() { Label = "Telegram", Url = "https://t.me/XiterShop" } };

            presence = new RichPresence()
            {
                Details = $"TG: t.me/XiterShop",
                State = "",
                Timestamps = rpctimestamp,
                Buttons = buttons,

                Assets = new Assets()
                {
                    LargeImageKey = "xiter",
                    LargeImageText = "Owner & Dev: @PointX_x",
                    SmallImageKey = "",
                    SmallImageText = ""
                }
            };
            SetState($"#1 Discord Osint Tool");
        }

        public static void SetState(string state, bool watching = false)
        {
            if (watching)
                state = "Looking at " + state;

            presence.State = state;
            client.SetPresence(presence);
        }
    }
}
