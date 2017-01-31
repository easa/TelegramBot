using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Venue
    {
        public Location location { get; set; }
        public string title { get; set; }
        public string address { get; set; }
        public string foursquare_id { get; set; }
    }
}
