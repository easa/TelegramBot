using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Chat
    {
        public long id { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool? all_members_are_administrators { get; set; }
    }

}
