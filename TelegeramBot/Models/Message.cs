using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    public class Message
    {
        public long message_id { get; set; }
        public From from { get; set; }
        public long date { get; set; }
        public Chat chat { get; set; }
        public User forward_from { get; set; }
        public Chat forward_from_chat { get; set; }
        public long? forward_from_message_id { get; set; }
        public long? forward_date { get; set; }
        public Message reply_to_message { get; set; }
        public long? edit_date { get; set; }
        public string text { get; set; }
        public List<MessageEntity> entities { get; set; }
        public Audio audio { get; set; }
        public Document document { get; set; }
        public Game game { get; set; }
        public List<PhotoSize> photo { get; set; }
        public Sticker sticker { get; set; }
        public Video video { get; set; }
        public Voice voice { get; set; }
        public string caption { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public Venue venue { get; set; }
        public User new_chat_member { get; set; }
        public User left_chat_member { get; set; }
        public string new_chat_title { get; set; }
        public List<PhotoSize> new_chat_photo { get; set; }
        public bool? delete_chat_photo { get; set; }
        public bool? group_chat_created { get; set; }
        public bool? supergroup_chat_created { get; set; }
        public bool? channel_chat_created { get; set; }
        public long? migrate_to_chat_id { get; set; }
        public long? migrate_from_chat_id { get; set; }
        public Message pinned_message { get; set; }
    }
}
