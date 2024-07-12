

using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.FromBodyModels;
using DTC.DefaultRepository.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Net8.Constants;
using Project.Net8.Controllers.DefaultRepository;
using Project.Net8.Installers;
using Project.Net8.Interface.Major;
using Project.Net8.Models.Major;
using Project.Net8.Models.PagingParam;

namespace Project.Net8.Controllers.Major
{
    [Route("api/v1/[controller]")]
  ///  [Authorize]
    public class BaiThiController : DefaultReposityController<BaiThiModel>
    {
        private readonly IBaiThiService _service;
        private DataContext _dataContext;
        private static string NameCollection = DefaultNameCollection.BAITHI;

        public BaiThiController(DataContext context,  IBaiThiService  service,  IHttpContextAccessor httpContextAccessor) : base(context, NameCollection,httpContextAccessor)
        {
            _service = service;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] BaiThiModel model)
        {
            try
            {

                var data = await _service.Create(model);
                return Ok(
                    new ResultMessageResponse()
                        .WithData(data)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.CREATE_SUCCESS)
                );
            }
            catch (ResponseMessageException ex)
            {
                return Ok(
                    new ResultMessageResponse().WithCode(ex.ResultCode)
                        .WithMessage(ex.ResultString).WithDetail(ex.Error)
                );
            }
        }
        [HttpPost]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] BaiThiModel model)
        {
            try
            {

                var data = await _service.Update(model);
                return Ok(
                    new ResultMessageResponse()
                        .WithData(data)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.UPDATE_SUCCESS)
                );
            }
            catch (ResponseMessageException ex)
            {
                return Ok(
                    new ResultMessageResponse().WithCode(ex.ResultCode)
                        .WithMessage(ex.ResultString).WithDetail(ex.Error)
                );
            }
        }

        [HttpPost]
        [Route("get-paging-params-core")]
        public override async Task<IActionResult> GetPagingCore([FromBody] PagingParamDefault pagingParam)
        {
            try
            {
                var response = await _service.GetPagingCore(pagingParam);
                return Ok(
                    new ResultMessageResponse()
                        .WithData(response)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.GET_DATA_SUCCESS)
                );
            }
            catch (ResponseMessageException ex)
            {
                return Ok(
                    new ResultMessageResponse().WithCode(ex.ResultCode)
                        .WithMessage(ex.ResultString)
                );
            }
        }

        #region Bài 3
        [HttpGet]
        [Route("get-tree-all")]
        public async Task<IActionResult> GetTreeAll()
        {
            try
            {
                var response = await _service.GetTreeAll();

                return Ok(
                    new ResultMessageResponse()
                        .WithData(response)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.GET_DATA_SUCCESS)
                );
            }
            catch (ResponseMessageException ex)
            {
                return Ok(
                    new ResultMessageResponse().WithCode(ex.ResultCode)
                        .WithMessage(ex.ResultString).WithDetail(ex.Error)
                );
            }
        }

        [HttpGet]
        [Route("get-list-cv-by-id/{id}")]
        public async Task<IActionResult> GetListById(string id)
        {
            try
            {
                var response = await _service.GetListById(id);

                return Ok(
                    new ResultMessageResponse()
                        .WithData(response)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.GET_DATA_SUCCESS)
                );
            }
            catch (ResponseMessageException ex)
            {
                return Ok(
                    new ResultMessageResponse().WithCode(ex.ResultCode)
                        .WithMessage(ex.ResultString).WithDetail(ex.Error)
                );
            }
        }
        #endregion
    }
}