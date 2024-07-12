using Project.Net8.Models.Core;

namespace Project.Net8.Interface.Core;



public interface IFileService
{
    Task<FileShortModel> SaveFileAsync(IFormFile file);
    
    Task<FileView> GetFileById(string id);

}
