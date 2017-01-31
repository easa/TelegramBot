using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class MessageEntity
    {
        public string type { get; set; }
        public long offset { get; set; }
        public long lenght { get; set; }
        public string url { get; set; }
        public User user { get; set; }
    }
}
