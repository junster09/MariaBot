using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using DiscordBotToo.Discord.Entities;

namespace DiscordBotToo.Discord
{
    public class Connection
    {

        private DiscordSocketClient _client;
        private DLogger _logger;

        public Connection(DLogger logger) {
            _logger = logger;

        }

        internal async Task ConnectAsync(MariaBotConfig config) {

            _client = new DiscordSocketClient(config.socketConfig);

            _client.Log += _logger.Log;
        }


    }
}
