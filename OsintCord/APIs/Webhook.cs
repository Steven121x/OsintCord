using DiscordMessenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsintCord.Others
{
    class Webhook
    {
        public static void SendMessage(string title, string Desc)
        {
            new DiscordMessage()
     .SetUsername("OsintCord")
 .SetAvatar("https://media.discordapp.net/attachments/1067718569078558800/1084303528090140692/9191044_71eae.gif?width=625&height=625")
     .AddEmbed()
         .SetTimestamp(DateTime.Now)
         .SetTitle(title)
         .SetAuthor("Dev By @PointX_x | TG: t.me/XiterShop")
         .SetDescription(Desc)
         .SetColor((int)1)
         .SetImage("https://media.discordapp.net/attachments/1067718569078558800/1084303528090140692/9191044_71eae.gif?width=625&height=625")
         .SetFooter("XitersShop", "https://media.discordapp.net/attachments/1067718569078558800/1084303528090140692/9191044_71eae.gif?width=625&height=625")
         .Build()
         .SendMessage(Global.webhook);

            var message = new DiscordMessage()
            {
                Content = "Kek",
                Embeds = new List<Embed>()
                    {
                        new Embed()
                        {
                            Description = "Kek"
                        }
                    }
            };

           
        }

    }
}
