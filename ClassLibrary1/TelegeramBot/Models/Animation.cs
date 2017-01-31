using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Animation
    {
        public string file_id { get; set; }
        public PhotoSize thumb { get; set; }
        public string file_name { get; set; }
        public string mime_type { get; set; }
        public int? file_size { get; set; }
    }
}
