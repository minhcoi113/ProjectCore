using Project.Net8.Models.Auth;
using Project.Net8.Models.Permission;

namespace Project.Net8.Interface.Auth
{
    public interface IIdentityService
    {
        Task<User> Authenticate(AuthRequest model);
        Task<dynamic> LoginAsync(AuthRequest model);
   
    }
}