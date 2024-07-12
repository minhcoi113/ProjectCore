using Project.Net8.Models.Permission;

namespace Project.Net8.Interface.Permission
{
    public interface IAPIService
    {
       
        Task<dynamic> Create(APIModel model);
        Task<dynamic> Update(APIModel model);
        
        
        Task<dynamic> AddAC(MenuList model);
        
        
        Task<dynamic>  DeleteAc(MenuList model);
        
        
        
        Task<dynamic>  Get();


    }
}