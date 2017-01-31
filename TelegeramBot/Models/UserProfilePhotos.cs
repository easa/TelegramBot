using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    class UserProfilePhotos
    {
        public int total_count { get; set; }
        public List<PhotoSize> photos { get; set; }
    }
}
