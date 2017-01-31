using System;
using System.Net;
using Newtonsoft.Json;
using TelegramBot.Models;

namespace TelegeramBot
{
    public class TelegramBot
    {
        /// <summary>
        /// Use this method to receive incoming updates using long polling (wiki). An Array of Update objects is returned.
        /// </summary>
        /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned. An update is considered confirmed as soon as getUpdates is called with an offset higher than its update_id. The negative offset can be specified to retrieve updates starting from -offset update from the end of the updates queue. All previous updates will forgotten.
        /// </param>
        /// <param name="limit">Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.
        /// </param>
        /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.
        /// </param>
        /// <param name="allowed_updates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.
        ///Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.
        ///</param>
        /// <returns>A ResponseData object is returned.</returns>
        public ResponseData getUpdates(int? offset = 0, int? limit = 100, int? timeout = 0, string[] allowed_updates = null)
        {
            string allowedUpdatesInQueryString = allowed_updates == null ? null : string.Format("&allowed_updates={0}", string.Join("&allowed_update=", allowed_updates));
            string parameters = string.Format("?offset={0}&limit={1}&timeout={2}{3}", offset, limit, timeout, allowedUpdatesInQueryString);
            string url = string.Format(address, token, Methods.getUpdates, parameters);
            string responseData = new WebClient().DownloadString(url);
            ResponseData ds = JsonConvert.DeserializeObject<ResponseData>(responseData);
            if (ds.ok)
                return ds;
            return null;
        }

        /// <summary>
        /// Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns true.
        /// If you'd like to make sure that the Webhook request comes from Telegram, we recommend using a secret path in the URL, e.g. https://www.example.com/<token>. Since nobody else knows your bot‘s token, you can be pretty sure it’s us.
        /// </summary>
        /// <param name="url">HTTPS url to send updates to. Use an empty string to remove webhook integration
        /// </param>
        /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our self-signed guide for details.
        /// </param>
        /// <param name="max_connections">Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot‘s server, and higher values to increase your bot’s throughput.
        /// </param>
        /// <param name="allowed_updates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.
        /// Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.
        /// </param>
        /// <returns></returns>
        public ResponseData setWebhook(string url, byte[] certificate, int? max_connections, string[] allowed_updates)
        {
            string allowedUpdatesInQueryString = allowed_updates == null ? null : string.Format("&allowed_updates={0}", string.Join("&allowed_update=", allowed_updates));
            string parameters = string.Format("?url={0}&certificate={1}&max_connections={2}{3}", url, certificate, max_connections, allowedUpdatesInQueryString);
            string _url = string.Format(address, token, Methods.getUpdates, parameters);
            string responseData = new WebClient().DownloadString(_url);
            ResponseData ds = JsonConvert.DeserializeObject<ResponseData>(responseData);
            if (ds.ok)
                return ds;
            return null;
        }


        public TelegramBot(string Token)
        {
            if (Token == null)
                throw new ArgumentNullException("Token could not be null!");
            token = Token;
        }

        string token;
        string address = "https://api.telegram.org/bot{0}/{1}{2}";
    }
}