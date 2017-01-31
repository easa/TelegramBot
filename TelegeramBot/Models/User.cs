﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelegramBot.Models
{
    /// <summary>
    /// This object represents a Telegram user or bot.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Unique identifier for this user or bot
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// User‘s or bot’s first name
        /// </summary>
        public string first_name { get; set; }
        /// <summary>
        /// Optional. User‘s or bot’s last name
        /// </summary>
        public string last_name { get; set; }
        /// <summary>
        /// Optional. User‘s or bot’s username
        /// </summary>
        public string username { get; set; }
    }
}
