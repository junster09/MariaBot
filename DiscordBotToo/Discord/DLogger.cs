using Discord;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DiscordBotToo.Discord
{
    public class DLogger
    {
        private ILogger _logger;

        public DLogger(ILogger Logger) {
            _logger = Logger;

        }
        public Task Log(LogMessage logMsg) {

            _logger.Log(logMsg.Message);
            return Task.CompletedTask;

        }

    }
}
