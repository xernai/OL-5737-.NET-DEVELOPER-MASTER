using Azure;
using Azure.Messaging.EventGrid;
using System;
using System.Threading.Tasks;

namespace EventGridSendConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string topicEndpoint = "";
            string topicKey = "";

            EventGridPublisherClient client = new EventGridPublisherClient(new Uri(topicEndpoint), new AzureKeyCredential(topicKey));
            await client.SendEventAsync(new EventGridEvent(
                "Advertencia de temperatura alta",
                "Warning",
                "1.0",
                "Tomar medidas contra el calor, sobre todo con la gente."
            ));
            Console.WriteLine("Event has been published.");
        }
    }
}
