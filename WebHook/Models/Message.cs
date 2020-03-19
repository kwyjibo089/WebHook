using Newtonsoft.Json;

namespace WebHook.Models
{
    public class Message
    {
        [JsonProperty(PropertyName = "meta")]
        public HeaderData Header { get; set; }

        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }
    }
}
