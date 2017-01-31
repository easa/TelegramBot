using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Sticker
    {
        public int width { get; set; }
        public int height { get; set; }
        public string emoji { get; set; }
        public PhotoSize thumb { get; set; }
        public string file_id { get; set; }
        public int file_size { get; set; }
    }
}
