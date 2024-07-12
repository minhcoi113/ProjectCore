using DTC.DefaultRepository.Models.Base;
using DTC.T;
using Project.Net8.Constants;

namespace Project.Net8.Models.Permission
{
   
    public class APIModel : Audit, TEntity<string>
    {
        public List<string> ListAction
        {
            get;
            set;
        } = new List<string>();



        public void SetListAction()
        {
            ListAction = new List<string>();
            foreach (var item in ListActionDefault.listActionAPI)
            {
                var actionName = Name.Trim() + "/" + item;
                this.ListAction.Add(actionName);
            }
        }
        
        
    }

    
    
    
    
    

}