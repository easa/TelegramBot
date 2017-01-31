using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Video
    {
        public string file_id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int duration { get; set; }
        public PhotoSize thumb { get; set; }
        public string mime_type { get; set; }
        public int file_size { get; set; }
    }
}
