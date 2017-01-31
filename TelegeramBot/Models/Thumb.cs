using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Thumb
    {
        public string file_id { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int file_size { get; set; }
    }
}
