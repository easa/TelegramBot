using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegeramBot.Models
{
    /// <summary>
    /// This object represents one button of the reply keyboard. For simple text buttons String can be used instead of this object to specify text of the button. Optional fields are mutually exclusive.
    /// </summary>
    class KeyboardButton
    {
        /// <summary>
        /// Text of the button. If none of the optional fields are used, it will be sent to the bot as a message when the button is pressed
        /// </summary>
        public string text { get; set; }
        /// <summary>
        /// Optional. If True, the user's phone number will be sent as a contact when the button is pressed. Available in private chats only
        /// </summary>
        public bool request_contact { get; set; }
        /// <summary>
        /// Optional. If True, the user's current location will be sent when the button is pressed. Available in private chats only
        /// </summary>
        public bool request_location { get; set; }
    }
}
