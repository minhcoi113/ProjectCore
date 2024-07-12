using Project.Net8.Models.Permission;
using Project.Net8.ViewModels;
using Project.Net8.ViewModels;

namespace Project.Net8.Interface.Permission
{
    public interface IMenuService
    {
        Task<List<MenuTreeVM>> GetTreeList();
        
        Task<dynamic> GetTreeFlatten();
        Task<dynamic> Create(Menu model);
        Task<dynamic> Update(Menu model);
        Task<dynamic> AddAC(MenuList model);
        Task<dynamic>  DeleteAc(MenuList model);
        
        
        
        Task<dynamic>  UpdateMenuAction();
        
        
        
        
        
        Task<List<NavMenuVM>> GetTreeListMenuForCurrentUser(List<Menu> listMenu);


        Task<List<NavMenuVM>> GetTreeListMenuAll(); 
    }
}