using DTC.DefaultRepository.Models.Base;
using DTC.T;

namespace Project.Net8.Models.Core
{
    public class FileModel : Audit, TEntity<string>
    {
        public string FileName { get; set; }
        public string SaveName { get; set; }
        public string Path { get; set; }
        
        public string PathFolder { get; set; }
        
        
        public long Size { get; set; }
        public string Ext { get; set; }
        

    

        public FileModel()
        {
            
        }
        
        
        
    }

    public class FileShortModel
    {
        public string FileId { get; set; }
        public string FileName { get; set; }
        
        public  string Ext { get; set;  }
        

        public FileShortModel()
        {
            
        }
        
        public FileShortModel(FileModel file)
        {
            this.FileId = file.Id;
            this.FileName = file.FileName;
            this.Ext = file.Ext;
        }
    }
    
    
    public class FileView
    {
        public MemoryStream data { get; set; } = new MemoryStream();
        
        public string FileName { get; set; }
        
        public string ContentType { get; set; }
    }




 
    
    
}