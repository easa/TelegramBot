using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class File
    {
        public string file_id { get; set; }
        public int? file_size { get; set; }
        public string file_path { get; set; }
    }
}
