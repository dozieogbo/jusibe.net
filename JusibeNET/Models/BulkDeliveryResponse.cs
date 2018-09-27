using Newtonsoft.Json;
using System;

namespace JusibeNET.Models
{
    public class BulkDeliveryResponse
    {
        [JsonProperty("bulk_message_id")]
        public string BulkMessageId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("created")]
        public DateTime Created { get; set; }
        [JsonProperty("processed")]
        public DateTime Processed { get; set; }
        [JsonProperty("total_numbers")]
        public int TotalNumbers { get; set; }
        [JsonProperty("total_unique_numbers")]
        public int UniqueNumbers { get; set; }
        [JsonProperty("total_valid_numbers")]
        public int ValidNumbers { get; set; }
        [JsonProperty("total_invalid_numbers")]
        public int InValidNumbers { get; set; }

        public override string ToString()
        {
            return $"Status -> {Status}, Message Id -> {BulkMessageId}";
        }
    }
}
