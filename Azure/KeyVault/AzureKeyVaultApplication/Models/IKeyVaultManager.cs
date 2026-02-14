using System.Threading.Tasks;

namespace AzureKeyVaultApplication.Models
{
    public interface IKeyVaultManager
    {
        public Task<string> GetSecret(string secretName);
    }
}
