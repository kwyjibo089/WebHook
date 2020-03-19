using Newtonsoft.Json;

namespace WebHook.Models
{
    public class HeaderData
    {
        [JsonProperty(PropertyName = "notificationType")]
        public string NotificationType { get; set; }
    }
}
