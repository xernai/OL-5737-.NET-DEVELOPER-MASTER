using System.Threading.Tasks;

namespace AzureKeyVaultDemo.Models
{
    public interface IKeyVaultManager
    {
        public Task<string> GetSecret(string secretName);
    }
}
