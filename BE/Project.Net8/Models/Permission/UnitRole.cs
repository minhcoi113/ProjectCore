using DTC.DefaultRepository.Models.Base;
using DTC.T;
using MongoDB.Bson.Serialization.Attributes;
using Project.Net8.Models.Core;

namespace Project.Net8.Models.Permission
{
    public class UnitRole : Audit , TEntity<string>
    {
        public string Code { get; set; }
        


        
        public List<ActionAPIModel> Controller { get; set; } = new List<ActionAPIModel>();

        
        
        public List<string> ListAction { get; set; } = new List<string>(); // Danh sách action của quyền  

        public List<string> ListMenu { get; set; } = new List<string>(); // Danh sách Menu mà quyền này có 



    }


    public class ActionAPIModel 
    {
        public string key { get; set; }

        public List<string> ListAction { get; set; } = new List<string>();
    }
    
    
    
    
    
    public class UnitRoleShort 
    {
      
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; } 
        public string Code { get; set; }
        
        public int Sort { get; set; }
        

        public List<CommonModelShort> KCCN { get; set; } = new List<CommonModelShort>();
        

        public bool IsProject { get; set; } = false;
        
        public bool IsDistrict { get; set; } = false;


        public List<ActionAPIModel> Controller { get; set; } = new List<ActionAPIModel>();
        
        
        public List<string> ListAction { get; set; } = new List<string>(); // Danh sách action của quyền  


        public UnitRoleShort(UnitRole model)
        {
            this.Id = model.Id;
            this.Name = model.Name;
            this.Sort = model.Sort;
            this.Code = model.Code;
            this.Controller = model.Controller;

            this.ListAction = model.ListAction;
        }



    }
    
    
    

    
}