using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RNR_sTelegramBot.Models
{
    public static class BotSettings
    {
        public static string Url { get; set; } = "telegrambot/"; // final url

        public static string Name { get; set; }

        public static string Key { get; set; }
    }
}