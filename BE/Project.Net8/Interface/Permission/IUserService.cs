using Project.Net8.Models.Permission;

namespace Project.Net8.Interface.Permission;

public interface IUserService
{
    Task<dynamic> Create(User model);
    
    
    Task<dynamic> Update(User model);

}