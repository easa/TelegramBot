using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelegeramBot.Models
{
    /// <summary>
    /// Contains information about the current status of a webhook.
    /// </summary>
    class WebhookInfo
    {
        /// <summary>
        /// Webhook URL, may be empty if webhook is not set up
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// True, if a custom certificate was provided for webhook certificate checks
        /// </summary>
        public bool has_custom_certificate { get; set; }
        /// <summary>
        /// Number of updates awaiting delivery
        /// </summary>
        public long pending_update_count { get; set; }
        /// <summary>
        /// Optional. Unix time for the most recent error that happened when trying to deliver an update via webhook
        /// </summary>
        public long? last_error_date { get; set; }
        /// <summary>
        /// Optional. Error message in human-readable format for the most recent error that happened when trying to deliver an update via webhook
        /// </summary>
        public string last_error_message { get; set; }
        /// <summary>
        /// Optional. Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery
        /// </summary>
        public long? max_connections { get; set; }
        /// <summary>
        /// Optional. A list of update types the bot is subscribed to. Defaults to all update types
        /// </summary>
        public string[] allowed_updates { get; set; }
    }
}
