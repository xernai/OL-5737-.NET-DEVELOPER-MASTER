using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Threading.Tasks;

namespace AzureKeyVaultDemoConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            const string secretName = "DbConectionString"; var keyVaultName = "ApplicationSecretsDemo3";
            var kvUri = $"https://{keyVaultName}.vault.azure.net";

            var client = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());

            Console.WriteLine($"Buscando el secreto desde {keyVaultName}.");

            var secret = await client.GetSecretAsync(secretName);
            Console.WriteLine($"El valor del secreto {secretName} es '{secret.Value.Value}'.");
        }
    }
}
