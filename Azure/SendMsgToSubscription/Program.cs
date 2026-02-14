using Azure.Messaging.ServiceBus;
using System;
using System.Threading.Tasks;


namespace SendMsgToSubscription
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // the client that owns the connection and can be used to create senders and receivers
            ServiceBusClient client;

            // the sender used to publish messages to the topic
            ServiceBusSender sender;

            client = new ServiceBusClient("");
            sender = client.CreateSender("rustico");

            // create a batch 
            using ServiceBusMessageBatch messageBatch = await sender.CreateMessageBatchAsync();
 
            try
            {
                var body = "Hay variedad de sabroso pan de muerto, visítanos.";
                var sbMessage = new ServiceBusMessage(body)
                {
                    CorrelationId = "Leon"
                };

                // sbMessage.ApplicationProperties.Add("Pan", "dulce");
                await sender.SendMessageAsync(sbMessage);
            }
            finally
            {
                // Calling DisposeAsync on client types is required to ensure that network
                // resources and other unmanaged objects are properly cleaned up.
                await sender.DisposeAsync();
                await client.DisposeAsync();
            }

            Console.WriteLine("Press any key to end the application");
            Console.ReadKey();
        }
    }
}
