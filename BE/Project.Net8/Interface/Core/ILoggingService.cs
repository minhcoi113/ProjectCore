
using Project.Net8.Service.Core;

namespace Project.Net8.Interface.Core
{
    public interface ILoggingService
    {
       
        Task<bool> SaveChanges();
        LoggingService WithDonVi(string? donVi);
        LoggingService WithContent(string? content);
        
        LoggingService WithStatus(int? status);
        
        
        LoggingService WithAPI(string? api);
      
    }
}