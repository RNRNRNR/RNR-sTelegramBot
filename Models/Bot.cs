using RNR_sTelegramBot.Models.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Telegram.Bot;

namespace RNR_sTelegramBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<BasicCommand> commandsList;

        public static IReadOnlyList<BasicCommand> Commands { get => commandsList.AsReadOnly(); }

        public static async Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            commandsList = new List<BasicCommand>(); 
            commandsList.Add(new AnsverHelloCommand()); //place to initialize the commands

            client = new TelegramBotClient(BotSetting.Key);
            await client.SetWebhookAsync("");

            return client;
        }

    }
}