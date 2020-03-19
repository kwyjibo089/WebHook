using Newtonsoft.Json;
using System;

namespace WebHook.Models
{
    public class UpdateMessage
    {
        [JsonProperty(PropertyName = "correlationId")]
        public Guid CorrelationId { get; set; }

        [JsonProperty(PropertyName = "timeStamp")]
        public DateTime TimeStamp { get; set; }

        [JsonProperty(PropertyName = "status")] 
        public string Status { get; set; }

    }
}
