using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using System;
using System.Threading.Tasks;

namespace Azure.CosmosDB.PeopleCRUD
{
    class People
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
    }

    class Address
    {
        public string City { get; set; }
        public string ZipCode { get; set; }
    }
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Local
            var connectionString = "";

            var client = new CosmosClientBuilder(connectionString)
                               .WithSerializerOptions(new CosmosSerializationOptions
                               {
                                   PropertyNamingPolicy = CosmosPropertyNamingPolicy.CamelCase
                               })
                               .Build();

            var peopleContainer = client.GetContainer("Ecommerce", "Employees");

            var person = new People
            {
                Id = "3",
                Name = "Anna",
                Address = new Address
                {
                    City = "Cd. México",
                    ZipCode = "100"
                }
            };

            await peopleContainer.CreateItemAsync(person);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
