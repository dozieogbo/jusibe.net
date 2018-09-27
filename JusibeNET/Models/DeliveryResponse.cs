using Newtonsoft.Json;
using System;

namespace JusibeNET.Models
{
    public class DeliveryResponse
    {
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("date_sent")]
        public DateTime DateSent { get; set; }
        [JsonProperty("date_delivered")]
        public DateTime DateDelivered { get; set; }

        public override string ToString()
        {
            return $"Status -> {Status}, Message Id -> {MessageId}";
        }
    }
}
