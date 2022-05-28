using System.Threading.Tasks;

namespace Mercado_dupolvo.Client.Auth
{
    public interface IAuthorizeService
    {
        Task Login(string token);
        Task Logout();
    }
}
