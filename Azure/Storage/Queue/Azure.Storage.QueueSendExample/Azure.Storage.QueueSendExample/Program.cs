using Microsoft.Azure.Storage.Queue;
using Microsoft.Azure.Storage;
using System;

namespace Azure.Storage.QueueSendExample
{
    internal class Program
    {
        public static string connstring =
           "";
        static void Main(string[] args)
        {
            AddMessage();
        }

        public static void AddMessage()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(connstring);
            CloudQueueClient cloudQueueClient = storageAccount.CreateCloudQueueClient();

            CloudQueue cloudQueue = cloudQueueClient.GetQueueReference("diplomado");

            CloudQueueMessage queueMessage = new CloudQueueMessage("Buenas tardes 4, sábado 5 de abril de 2025. ");
            cloudQueue.AddMessage(queueMessage);

            Console.WriteLine("Message sent");
        }
    }
}
