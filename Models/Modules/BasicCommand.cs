using Telegram.Bot.Types;
using Telegram.Bot;

namespace RNR_sTelegramBot.Models.Modules
{
    public abstract class BasicCommand // template for commands
    {
        public abstract string Name { get; }

        public abstract void Execute(Message msg, TelegramBotClient client);

        public bool ContainsOther(string command)// check command for a copy
        {
            return command.Contains(this.Name) && command.Contains(BotSettings.Name);
        }
    }
}