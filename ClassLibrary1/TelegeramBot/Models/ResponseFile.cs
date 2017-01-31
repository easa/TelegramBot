using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class ResponseData_File
    {
        public bool ok { get; set; }
        public int? error_code { get; set; }
        public string description { get; set; }
        public File result { get; set; }
    }
}
