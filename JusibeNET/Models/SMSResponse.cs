using Newtonsoft.Json;

namespace JusibeNET.Models
{
    public class SMSResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
        [JsonProperty("sms_credits_used")]
        public int SMSCreditsUsed { get; set; }

        public override string ToString()
        {
            return $"Status -> {Status}, Message Id -> {MessageId}, Total Credits -> {SMSCreditsUsed}";
        }
    }
}
