using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using Microsoft.AspNetCore.Mvc;
using Project.Net8.Constants;
using Project.Net8.Installers;
using Project.Net8.Interface.Common;
using Project.Net8.Models.Core;

namespace Project.Net8.Controllers.Common;
[ApiController]
//[Authorize]
[Route("api/v1/[controller]")]
public class CommonController : CommonRepositoryController<CommonModel, string>
{
    private DataContext _dataContext;
    private readonly ICommonService _service;
    public CommonController(ICommonService service) : base(service)
    {
        this._service = service;
    }
    [HttpGet]
    [Route("get-list")]
    public async Task<IActionResult> GetList()
    {
        try
        {
            var response = ListCommon.listCommon;
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