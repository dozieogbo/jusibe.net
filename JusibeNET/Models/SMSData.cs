using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace JusibeNET.Models
{
    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    internal class SMSData
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Message { get; set; }

        public SMSData(string from, string to, string message)
        {
            From = from;
            To = to;
            Message = message;
        }
    }
}
