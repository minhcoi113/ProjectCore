using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using Microsoft.AspNetCore.Mvc;
using Project.Net8.Constants;
using Project.Net8.Controllers.DefaultRepository;
using Project.Net8.Installers;
using Project.Net8.Interface.Permission;
using Project.Net8.Models.Permission;

namespace Project.Net8.Controllers.Permission
{
    [Route("api/v1/[controller]")]
   // [Authorize]
    public class APIController : DefaultReposityController<APIModel>
    {
        private readonly IAPIService _service;
       // private DataContext _dataContext;
        private static string NameCollection = DefaultNameCollection.API;
        
        
   //     private readonly IHttpContextAccessor _httpContextAccessor;
        
        public APIController(DataContext context, IAPIService service,  IHttpContextAccessor httpContextAccessor) : base(context, NameCollection,httpContextAccessor)
        {
            _service = service;
        }
  
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] APIModel model)
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
        public async Task<IActionResult> Update([FromBody] APIModel model)
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
        [Route("add-action")]
        public async Task<IActionResult> AddAC([FromBody] MenuList model)
        {
            try
            {

                var data = await _service.AddAC(model);
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
        [Route("delete-action")]
        public async Task<IActionResult> DeleteAc([FromBody] MenuList model)
        {
            try
            {
                var data = await _service.DeleteAc(model); 

                return Ok(
                    new ResultMessageResponse()
                        .WithData(data)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.DELETE_SUCCESS)
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
        [Route("get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var data = await _service.Get();

                return Ok(
                    new ResultMessageResponse()
                        .WithData(data)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.DELETE_SUCCESS)
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

        
        
        
        
    }
}