using JusibeNET.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace JusibeNET
{
    public class Jusibe
    {
        private const string BASE_URL = "https://jusibe.com";

        private readonly string _accessToken;
        private readonly string _publicKey;
        private readonly HttpClient _client;

        public Jusibe(string publicKey, string accessToken)
        {
            _accessToken = accessToken;
            _publicKey = publicKey;

            _client = InitializeClent();
        }

        private HttpClient InitializeClent()
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri(BASE_URL)
            };
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
                Convert.ToBase64String(Encoding.Default.GetBytes($"{_publicKey}:{_accessToken}")));
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            return client;
        }

        public async Task<SMSResponse> SendSMS(string from, string to, string message)
        {
            var body = new SMSData(from, to, message);

            var response = await _client.PostAsJsonAsync("smsapi/send_sms", body);

            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<SMSResponse>(responseData);
        }

        public async Task<BulkSMSResponse> SendBulkSMS(string from, List<string> to, string message)
        {
            var body = new SMSData(from, String.Join(",", to), message);

            var response = await _client.PostAsJsonAsync("smsapi/bulk/send_sms", body);

            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BulkSMSResponse>(responseData);
        }

        public async Task<BulkDeliveryResponse> CheckBulkSMSStatus(string bulkMessageId)
        {
            var response = await _client.GetAsync($"smsapi/bulk/status?bulk_message_id={bulkMessageId}");

            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<BulkDeliveryResponse>(responseData);
        }

        public async Task<DeliveryResponse> CheckSMSStatus(string messageId)
        {
            var response = await _client.GetAsync($"smsapi/delivery_status?message_id={messageId}");

            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<DeliveryResponse>(responseData);
        }

        public async Task<int> CheckAvaliableCredits()
        {
            var response = await _client.GetAsync("smsapi/get_credits");

            response.EnsureSuccessStatusCode();

            var responseData = await response.Content.ReadAsStringAsync();

            var creditsData = JsonConvert.DeserializeObject<CreditsResponse>(responseData);

            return creditsData.SMSCredits;
        }
    }
}
