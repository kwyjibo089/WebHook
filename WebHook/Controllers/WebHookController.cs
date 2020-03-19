using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using WebHook.Models;

namespace WebHook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebHookController : ControllerBase
    {
        [HttpPost]
        [Route("notification")]
        public IActionResult NotificationAsync([FromBody] JObject jObject)
        {
            Message message = jObject.ToObject<Message>();

            switch (message.Header.NotificationType)
            {
                case "update":
                    JObject notificationData = (JObject)message.Data;
                    var updateMessage = notificationData.ToObject<UpdateMessage>();

                    return Ok($"Message {updateMessage.CorrelationId} " +
                        $"with status {updateMessage.Status} " +
                        $"and timestamp {updateMessage.TimeStamp}.");

                case "foo":
                    // handling of other types

                    break;

                case "bar":
                    // handling of other types

                    break;

                default:

                    break;
            }

            return BadRequest($"Unknown notification type {message.Header.NotificationType}");
        }
    }
}