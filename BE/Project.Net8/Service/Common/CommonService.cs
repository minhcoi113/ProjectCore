using Project.Net8.Installers;
using Project.Net8.Interface.Common;
using Project.Net8.Models.Core;
using Project.Net8.Service.Core;

namespace Project.Net8.Service.Common;

public class CommonService: CommmonRepository<CommonModel, string>, ICommonService
{
       
    public CommonService(DataContext context, IHttpContextAccessor contextAccessor) :
        base(context, contextAccessor)
    {
    }
    
        
}