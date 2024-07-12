using Newtonsoft.Json;
using Project.Net8.Models.Permission;

namespace Project.Net8.ViewModels
{
    public class NavMenuVM
    {
        public NavMenuVM(Menu model)
        {
            this.Id = model.Id  ?? "";
            this.Name = model.Name  ?? "";
            this.Icon = model.Icon  ?? "";
            this.ParentId = model.ParentId ?? "";
            this.Link = string.IsNullOrEmpty(model.Path)? "/" : model.Path; 
            this.IsTitle = model.Level == 0 ? true : false;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string ParentId { get; set; }
        public string Link { get; set; }
        public bool IsTitle { get; set; }
        public int Level { get; set; }

        public List<NavMenuVM> Children { get; set; } = new List<NavMenuVM>();
    }
}