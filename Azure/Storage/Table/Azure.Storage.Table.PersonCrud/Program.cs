using Azure.Data.Tables;
using System;

namespace Azure.Storage.Table.PersonCrud
{
    class ClientEntity : ITableEntity
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }

        public string Phone { get; set; }

        public string Profile { get; set; }

        public string Hobbies { get; set; }

        public DateTimeOffset? Timestamp { get; set; }
        public ETag ETag { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // local connection
            var connectionString = "";

            // remote connection
            // var connectionString =  ""; 

            var tableName = "clientes";

            var tableClient = new TableClient(connectionString, tableName);

            // Create the table if it doesn't already exist to verify we've successfully authenticated.
            tableClient.CreateIfNotExists();

            AddEntity1(tableClient);
            // Update
            // Delete
            // Get
        }

        static void AddEntity1(TableClient tableClient)
        {
            ClientEntity personEntity = new ClientEntity
            {
                PartitionKey = "Client",
                RowKey = "1",
                FirstName = "Armando",
                LastName = "Almaguer",
                Age = 20,
                Country = "MX",
                Profile = ".NET Developer",
                Hobbies = "Reparar computadoras"
            };
            tableClient.AddEntity(personEntity);
        }
    }
}
