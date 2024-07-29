using Project.Net8.Models.Permission;
using Project.Net8.ViewModels;

namespace Project.Net8.Interface.Permission;

public interface IUserService
{
    Task<dynamic> Create(User model);
    
    
    Task<dynamic> Update(User model);

    Task<dynamic> ChangePassword(UserVM model);
}