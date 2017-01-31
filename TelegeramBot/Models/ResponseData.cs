using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class ResponseData
    {
        public bool ok { get; set; }
        public List<Update> result { get; set; }
        public int? error_code { get; set; }
        public string description { get; set; }
        public Message Message { get; set; }
    }
}
