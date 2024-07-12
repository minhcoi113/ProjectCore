using Project.Net8.FromBodyModels;
using Project.Net8.Models.Permission;

namespace Project.Net8.Interface.Permission
{
    public interface IUnitRoleService
    {
        Task<dynamic> Create(UnitRole model);
        Task<dynamic> Update(UnitRole model);
        
        
        Task<dynamic> UpdateAction(IdFromBodyUnitRole model);
        
        
        Task<dynamic> UpdateController(UnitRole model);
        




    }
}