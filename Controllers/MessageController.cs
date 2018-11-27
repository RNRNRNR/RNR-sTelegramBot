using RNR_sTelegramBot.Models;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;

namespace RNR_sTelegramBot.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")]// url part
        public async Task<OkResult> Update([FromBody]Update update)
        {
            var commands = Bot.Commands;
            var msg = update.Message;
            var client = await Bot.Get();

            foreach (var command in commands)
            {
                if (command.ContainsOther(msg.Text))
                {
                    command.Execute(msg, client);
                    break;
                }
            }
            return Ok();
        }
    }
}
