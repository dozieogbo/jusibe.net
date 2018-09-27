using Newtonsoft.Json;

namespace JusibeNET.Models
{
    public class BulkSMSResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("bulk_message_id")]
        public string BulkMessageId { get; set; }
        [JsonProperty("request_speed")]
        public double RequestSpeed { get; set; }

        public override string ToString()
        {
            return $"Status -> {Status}, Message Id -> {BulkMessageId}";
        }
    }
}
