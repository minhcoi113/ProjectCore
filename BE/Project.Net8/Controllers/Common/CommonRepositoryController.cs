using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using DTC.T;
using Microsoft.AspNetCore.Mvc;
using Project.Net8.FromBodyModels;
using Project.Net8.Interface.Common;
using Project.Net8.Models.PagingParam;

namespace Project.Net8.Controllers.Common
{
    public abstract class CommonRepositoryController<TEntity, UEntityId> : ControllerBase
        where TEntity : class, IIdEntity<UEntityId>
    {
        protected readonly ICommonRepository<TEntity, UEntityId> Repository;

        public CommonRepositoryController(ICommonRepository<TEntity, UEntityId> repository)
        {
            Repository = repository;
        }

        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody] TEntity model)
        {
            try
            {
                var response = await Repository.CreateAsync(model);
                return Ok(
                    new ResultMessageResponse()
                        .WithData(response)
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
        public async Task<IActionResult> Update([FromBody] TEntity model)
        {
            try
            {
                var response = await Repository.UpdateAsync(model);

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
                        .WithMessage(ex.ResultString).WithDetail(ex.Error)
                );
            }
        }

        [HttpPost]
        [Route("delete")]
        public async Task<IActionResult> Delete([FromBody] TEntity model)
        {
            try
            {
                await Repository.DeleteAsync(model);

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
        [Route("get-by-id")]
        public async Task<IActionResult> GetById([FromBody] IdFromBodyCommonModel Id)
        {
            try
            {
                var response = await Repository.GetByIdAsync(Id);

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
        [Route("get-paging-params")]
        public async Task<IActionResult> GetPagingParam([FromBody] CommonPaging param)
        {
            try
            {
                var response = await Repository.GetPagingAsync(param);

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
        [Route("get-all/{collectionName}")]
        public async Task<IActionResult> GetAllData(string collectionName)
        {
            try
            {
                var response = await Repository.GetAsync(collectionName);
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