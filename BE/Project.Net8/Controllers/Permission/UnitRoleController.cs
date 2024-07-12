using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using Microsoft.AspNetCore.Mvc;
using Project.Net8.Constants;
using Project.Net8.Controllers.DefaultRepository;
using Project.Net8.FromBodyModels;
using Project.Net8.Installers;
using Project.Net8.Interface.Permission;
using Project.Net8.Models.PagingParam;
using Project.Net8.Models.Permission;

namespace Project.Net8.Controllers.Permission
{
    [Route("api/v1/[controller]")]
  //  [Authorize]
    public class UnitRoleController: DefaultReposityController<UnitRole>
    {
        private IUnitRoleService _service;
        private static string NameCollection = DefaultNameCollection.UNIT_ROLE;
        
     //   private readonly IHttpContextAccessor _httpContextAccessor;
        public UnitRoleController(DataContext context,  IUnitRoleService service,  IHttpContextAccessor httpContextAccessor) : base(context, NameCollection,httpContextAccessor)
        {
            _service = service;
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] UnitRole model)
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
        public async Task<IActionResult> Update([FromBody] UnitRole model)
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
                        .WithMessage(ex.ResultString)
                );
            }
        }
        
        
        [HttpPost]
        [Route("update-action")]
        public async Task<IActionResult> UpdateAction([FromBody] IdFromBodyUnitRole model)
        {
            try
            {
                var response = await _service.UpdateAction(model);
                return Ok(
                    new ResultMessageResponse()
                        .WithData(response)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.UPDATE_SUCCESS)
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
        
        [HttpPost]
        [Route("update-controller")]
        public async Task<IActionResult> UpdateController([FromBody] UnitRole model)
        {
            try
            {
                var response = await _service.UpdateController(model);
                return Ok(
                    new ResultMessageResponse()
                        .WithData(response)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.UPDATE_SUCCESS)
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
        
        
        [HttpGet]
        [Route("get-all-core")]
        public override async Task<IActionResult> GetAllData()
        {
            try
            {
                var response = await  Repository.GetAll();
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
        
        [HttpPost]
        [Route("get-paging-params-core")]
        public override async Task<IActionResult> GetPagingCore([FromBody] PagingParamDefault pagingParam)
        {
            try
            {
                var response = await  Repository.GetPagingCore(pagingParam);
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
    }
}
