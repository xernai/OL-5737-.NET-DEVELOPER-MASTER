using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.ServiceBus;

namespace SendMsgToTopicReceivedFromSubscription
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Set the Service Bus connection string
            string connectionString = "";

            // Create a new TopicClient instance
            var topicClient = new TopicClient(connectionString, "rustico");

            // Create a new message object
            var message = new Message(Encoding.UTF8.GetBytes("Hello, world!"));

            // Add custom properties to the message
            message.UserProperties.Add("MyProperty", "MyValue");

            // Send the message to the topic
            await topicClient.SendAsync(message);

            Console.WriteLine("Message sent to topic.");

            // Create a new SubscriptionClient instance
            var subscriptionClient = new SubscriptionClient(connectionString, "rustico", "S1");

            // Create a rule for the subscription that filters messages based on a property value
            var ruleDescription = new RuleDescription
            {
                Filter = new CorrelationFilter
                {
                    Label = "Important"
                },
                Name = "ImportantMessages"
            };
            await subscriptionClient.AddRuleAsync(ruleDescription);

            Console.WriteLine("Subscription rule created.");

            // Register a message handler
            subscriptionClient.RegisterMessageHandler(async (msg, token) =>
            {
                // Process the message
                string body = Encoding.UTF8.GetString(msg.Body);
                Console.WriteLine($"Received message: {body}");

                // Check for custom properties in the message
                if (msg.UserProperties.ContainsKey("MyProperty"))
                {
                    string value = msg.UserProperties["MyProperty"].ToString();
                    Console.WriteLine($"Custom property found: {value}");
                }

                // Complete the message so it's removed from the subscription
                await subscriptionClient.CompleteAsync(msg.SystemProperties.LockToken);
            }, new MessageHandlerOptions(args =>
            {
                Console.WriteLine(args.Exception.ToString());
                return Task.CompletedTask;
            })
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            });

            Console.WriteLine("Waiting for messages...");

            // Wait for user input to exit
            Console.ReadLine();
        }
    }
}