using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.Net8.Constants;
using Project.Net8.Controllers.DefaultRepository;
using Project.Net8.Installers;
using Project.Net8.Interface.Permission;
using Project.Net8.Models.Permission;
using Project.Net8.Service.Permission;
using Project.Net8.ViewModels;

namespace Project.Net8.Controllers.Permission
{
    [Route("api/v1/[controller]")]
    // [Authorize]
    public class UsersController : DefaultReposityController<User>
    {
        private readonly IUserService _service;
        private DataContext _dataContext;
        private static string NameCollection = DefaultNameCollection.USERS;

        public UsersController  (DataContext context, IUserService service,IHttpContextAccessor httpContextAccessor) : base(context, NameCollection,httpContextAccessor)
        {
            _service = service;
            _dataContext = context;
        }
        
        
        
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] User model)
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
        public async Task<IActionResult> Update([FromBody] User model)
        {
            try
            {
                var data = await _service.Update(model);
                return Ok(
                    new ResultMessageResponse()
                        .WithData(data)
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.UPDATE_SUCCESS));
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
        [Route("change-password")]
        public async Task<IActionResult> ChangePassword([FromBody] UserVM model)
        {
            try
            {
                var data = await _service.ChangePassword(model);

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
    }
}