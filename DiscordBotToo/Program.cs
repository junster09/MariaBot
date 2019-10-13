using DiscordBotToo.Discord;
using DiscordBotToo.Discord.Entities;
using DiscordBotToo.Storage;
using System;
using System.Threading.Tasks;

namespace DiscordBotToo
{
    internal class Program
    {
        

        private static async Task Main()
        {
            Unity.RegisterTypes();
            Console.WriteLine("I'm following a tutorial eccks dee");

            var discordBotConfig = new MariaBotConfig
            {
                Token = "aewubfgasuebf",
                socketConfig = DiscordStealer.GetDefault()

            };

            var connection = Unity.Resolve<Connection>();

            

        }


    }

}
