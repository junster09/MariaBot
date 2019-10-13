using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;
/*
    data class
*/
namespace DiscordBotToo.Discord.Entities
{
    public class MariaBotConfig
    {
        public string Token { get; set; }

        public DiscordSocketConfig socketConfig;

    }
}
