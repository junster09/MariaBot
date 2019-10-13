using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscordBotToo.Discord
{
    public static class DiscordStealer
    {
        public static DiscordSocketConfig GetDefault() {

            return new DiscordSocketConfig() {
                LogLevel = LogSeverity.Verbose

            };
        }

        public static DiscordSocketConfig GetNew() {

            return new DiscordSocketConfig();

        }


    }
}
