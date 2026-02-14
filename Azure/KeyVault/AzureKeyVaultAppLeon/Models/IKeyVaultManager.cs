using System.Threading.Tasks;

namespace AzureKeyVaultAppLeon.Models
{
    public interface IKeyVaultManager
    {
        public Task<string> GetSecret(string secretName);
    }
}
