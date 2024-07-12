using Project.Net8.Models.Permission;

namespace Project.Net8.ViewModels
{
    public class MenuTreeVM
    {
     
        public MenuTreeVM(Menu model)
        {
            this.Id = model.Id;
            this.Label = model.Name;
            this.Link = model.Path ?? "";
            this.Icon = model.Icon ?? "";
            this.ParentId = model.ParentId;
        }
        public string Id { get; set; }
        public string Label { get; set; }

        public List<MenuTreeVM> Children { get; set; }

        public string ParentId { get; set; }= "";
        public string Link { get; set; } = "";
        public string Icon { get; set; } = "";
        public bool Selected { get; set; } = false;
        public bool Opened { get; set; } = false;
        
    }
    public class MenuTreeVMGetAll
    {
        public MenuTreeVMGetAll(Menu model)
        {
            this.Id = model.Id;
            this.Label = model.Name;
            this.Code = model.Resource; 
            this.CapDV = model.Level;
        }
        public string Id { get; set; }
        public string Label { get; set; }
        
        public string Code { get; set; }
        
        public int CapDV { get; set; }
        
    }
    
    
}