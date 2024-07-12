using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.FromBodyModels;
using DTC.DefaultRepository.Helpers;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Project.Net8.FromBodyModels;
using Project.Net8.Installers;
using Project.Net8.Interface.DefaultRepository;
using Project.Net8.Models.PagingParam;
using Project.Net8.Service.DefaultRepository;

namespace Project.Net8.Controllers.DefaultRepository
{
    public abstract class DefaultReposityController<T> : ControllerBase where T : class
    {
        protected readonly IDefaultReposityService<T> Repository;
        public IMongoCollection<T> _collection;
        public DefaultReposityController(DataContext context ,  string collectionName,IHttpContextAccessor httpContextAccessor)
        {
            _collection = context.Database.GetCollection<T>(collectionName);
            Repository = new DefaultReposityService<T>(_collection , context,httpContextAccessor );
         //   Repository.getCollection(_collection);
        }
       
        
        [HttpGet]
        [Route("get-all-core")]
        public virtual async Task<IActionResult> GetAllData()
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
        
        
        [HttpGet]
        [Route("get-all-selected")]
        public virtual async Task<IActionResult> GetAllSelected()
        {
            try
            {
                var response = await  Repository.GetAllSelected();
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
        [Route("get-by-id-core")]
        public async Task<IActionResult> GetById([FromBody] IdFromBodyModel model)
        {
            try
            {
                var response = await  Repository.GetById(model);
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
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody] IdFromBodyModel model)
        {
            try
            {
                await  Repository.Delete(model);
                return Ok(
                    new ResultMessageResponse()
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.DELETE_SUCCESS)
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
        [Route("deleted")]
        public async Task<IActionResult> Deleted([FromBody] IdFromBodyModel model)
        {
            try
            {
                await  Repository.Deleted(model);
                return Ok(
                    new ResultMessageResponse()
                        .WithCode(DefaultCode.SUCCESS)
                        .WithMessage(DefaultMessage.DELETE_SUCCESS)
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
        public virtual async Task<IActionResult> GetPagingCore([FromBody] PagingParamDefault pagingParam)
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

        
        
        
        
        [HttpPost]
        [Route("get-all-paging-params-core")]
        public virtual async Task<IActionResult> GetAllPagingCore([FromBody] PagingParamDefault pagingParam)
        {
            try
            {
                var response = await  Repository.GetAllPagingCore(pagingParam);
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