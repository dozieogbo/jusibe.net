using System;
using System.Collections.Generic;

namespace JusibeNET.Example
{
    class Program
    {
        static Jusibe jusibe;

        static void Main(string[] args)
        {
            string publicKey = "--INSERT YOUR PUBLIC KEY--";
            string accessToken = "--INSERT YOUR ACCESS TOKEN--";

            jusibe = new Jusibe(publicKey, accessToken);

            Console.WriteLine("Trying Jusibe API...");

            //SendBulkSMS();
            //SendSMS();
            //CheckDeliveryStatus();
            //CheckBulkDeliveryStatus();

            GetCredits();

            Console.ReadKey();
        }

        static async void GetCredits()
        {
            var credits = await jusibe.CheckAvaliableCredits();

            Console.WriteLine("Credits response...");
            Console.WriteLine(credits);
        }

        static async void SendBulkSMS()
        {
            var status = await jusibe.SendBulkSMS("JusibeNET", new List<string>() { "08088888888" }, "Hello from .NET");

            Console.WriteLine("Single SMS response...");
            Console.WriteLine(status);
        }

        static async void SendSMS()
        {
            var status = await jusibe.SendSMS("JusibeNET", "08088888888", "Hello from .NET");

            Console.WriteLine("Bulk SMS response...");
            Console.WriteLine(status);
        }

        static async void CheckDeliveryStatus()
        {
            var status = await jusibe.CheckSMSStatus("qe1mm3x71b");

            Console.WriteLine("Delivery Status response...");
            Console.WriteLine(status);
        }

        static async void CheckBulkDeliveryStatus()
        {
            var status = await jusibe.CheckBulkSMSStatus("qe1mm3x71b");

            Console.WriteLine("Delivery Status response...");
            Console.WriteLine(status);
        }
    }
}
