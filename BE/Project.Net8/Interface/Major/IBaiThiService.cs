using DTC.DefaultRepository.FromBodyModels;
using Microsoft.AspNetCore.Mvc;
using Project.Net8.Models.Major;
using Project.Net8.Models.PagingParam;

namespace Project.Net8.Interface.Major
{
    public interface IBaiThiService
    {
        Task<dynamic> Create(BaiThiModel model);
        Task<dynamic> Update(BaiThiModel model);
        Task<dynamic> GetPagingCore(PagingParamDefault pagingParam);
        #region bài 3

        Task<dynamic> GetTreeAll();

        Task<dynamic> GetListById(string id);
        #endregion
    }
}