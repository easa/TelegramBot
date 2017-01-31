using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Game
    {
        public string title { get; set; }
        public string description { get; set; }
        public List<PhotoSize> photo { get; set; }
        public string text { get; set; }
        public List<MessageEntity> text_entities { get; set; }
        public Animation animation { get; set; }
    }
}
