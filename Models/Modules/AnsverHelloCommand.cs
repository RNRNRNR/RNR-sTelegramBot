using Telegram.Bot;
using Telegram.Bot.Types;

namespace RNR_sTelegramBot.Models.Modules
{
    public class AnsverHelloCommand : BasicCommand
    {
        public override string Name => "hello";

        public override async void Execute(Message msg, TelegramBotClient client)
        {
            var chatId = msg.Chat.Id;
            var messageId = msg.MessageId;

            await client.SendTextMessageAsync(chatId, "Hi!", replyToMessageId: 1);
        }
    }
}