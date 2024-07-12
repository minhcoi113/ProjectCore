using Project.Net8.Models.Major;

namespace Project.Net8.ViewModels
{
    public class BaiThiTreeVM
    {
        public BaiThiTreeVM(BaiThiModel model)
        {
            this.Id = model.Id;
            this.Label = model.Name;
            this.ParentId = model.ParentId;
        }
        public string Id { get; set; }
        public string Label { get; set; }
        public string ParentId { get; set; } = "";
        public List<BaiThiTreeVM> Children { get; set; }
    }
}
