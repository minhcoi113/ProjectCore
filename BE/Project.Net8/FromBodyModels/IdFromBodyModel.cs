
using DTC.DefaultRepository.FromBodyModels;

namespace Project.Net8.FromBodyModels
{

    
    public class IdFromBodyCommonModel : IdFromBodyModel
    {
        public string CollectionName { get; set; }
    }
    
    
    public class IdFromBodyUnitRole : IdFromBodyModel
    {
        public List<string> ListAction { get; set; }
    }
    
    
    

    
    
    
}