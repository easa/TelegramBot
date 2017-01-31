using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Audio
    {
        public string file_id { get; set; }
        public long duration { get; set; }
        public string performer { get; set; }
        public string title { get; set; }
        public string mime_type { get; set; }
        public long? file_size { get; set; }
    }
}
