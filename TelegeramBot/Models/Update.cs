using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    /// <summary>
    /// This object represents an incoming update.
    /// At most one of the optional parameters can be present in any given update.
    /// </summary>
    public class Update
    {
        /// <summary>
        /// The update‘s unique identifier. Update identifiers start from a certain positive number and increase sequentially. This ID becomes especially handy if you’re using Webhooks, since it allows you to ignore repeated updates or to restore the correct update sequence, should they get out of order.
        /// </summary>
        public long update_id { get; set; }
        /// <summary>
        /// Optional. New incoming message of any kind — text, photo, sticker, etc.
        /// </summary>
        public Message message { get; set; }
        /// <summary>
        /// Optional. New version of a message that is known to the bot and was edited
        /// </summary>
        public Message edited_message { get; set; }
        /// <summary>
        /// Optional. New incoming channel post of any kind — text, photo, sticker, etc.
        /// </summary>
        public Message channel_post { get; set; }
        /// <summary>
        /// Optional. New version of a channel post that is known to the bot and was edited
        /// </summary>
        public Message edited_channel_post { get; set; }
        /// <summary>
        /// Optional. New incoming inline query
        /// </summary>
        public InlineQuery inline_query { get; set; }
        /// <summary>
        /// Optional. The result of an inline query that was chosen by a user and sent to their chat partner.
        /// </summary>
        public Message chosen_inline_result { get; set; }
        /// <summary>
        /// Optional. New incoming callback query
        /// </summary>
        public Message callback_query { get; set; }
    }
}
