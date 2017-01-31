using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class From
    {
        public long id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
    }
}
