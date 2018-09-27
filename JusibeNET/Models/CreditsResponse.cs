using Newtonsoft.Json;

namespace JusibeNET.Models
{
    public class CreditsResponse
    {
        [JsonProperty("sms_credits")]
        public int SMSCredits { get; set; }

        public override string ToString()
        {
            return $"Total Credits Left -> {SMSCredits}";
        }
    }
}
