using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using DTC.T;
using FluentValidation.Results;
using MongoDB.Driver;
using Project.Net8.Constants;
using Project.Net8.FromBodyModels;
using Project.Net8.Installers;
using Project.Net8.Interface.Common;
using Project.Net8.Models.Core;
using Project.Net8.Models.PagingParam;
using Project.Net8.Service.Base;
using Project.Net8.Validation.Common;

namespace Project.Net8.Service.Common;

public class CommmonRepository<TEntity, UEntityId> : BaseService,  ICommonRepository<TEntity, UEntityId>
    where TEntity : class, IIdEntity<UEntityId>
{
    private readonly IHttpContextAccessor _contextAccessor;
    protected readonly DataContext _context;
        
    protected IMongoCollection<TEntity> _collection;
    
    
    protected IMongoCollection<dynamic> _collectionDynamic;
    
    protected IMongoCollection<CommonModel> _collectionCommon;

    private HttpContext _httpContext { get { return _contextAccessor.HttpContext; } }
    
    public string CollectionName { get; set; }
        

    public CommmonRepository(DataContext context, IHttpContextAccessor contextAccessor ) : base(context, contextAccessor)
    {
        _context = context;
        _contextAccessor = contextAccessor;
    }

    public virtual async Task<long> CountAsync()
    {
        return await _collection.Find(x => true).CountDocumentsAsync();
    }

    public virtual async Task<TEntity> GetByIdAsync(IdFromBodyCommonModel model)
    {
        try
        {
            if (model == null || model.Id == null || model.CollectionName == null)
            {
                throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
            }

            var value = ListCommon.listCommon.Where(x => x.Code == model.CollectionName).FirstOrDefault();
            if (value == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            _collection = (IMongoCollection<TEntity>)_context.GetCategoryCollectionAs(model.CollectionName);
            if (_collection.CollectionNamespace.DatabaseNamespace == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            var entity = await _collection.Find(x => x.Id.Equals(model.Id) && !x.IsDeleted).FirstOrDefaultAsync();
            if (entity == default)
            {
                throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
            }

            return entity;
        }
        catch (ResponseMessageException e)
        {
            throw new ResponseMessageException()
                .WithCode(DefaultCode.EXCEPTION)
                .WithMessage(e.ResultString);
        }
        catch (Exception e)
        {
            if (e.Message.Contains("is not a valid 24 digit hex string."))
            {
                throw new ResponseMessageException().WithException(DefaultCode.ID_NOT_CORRECT_FORMAT);
            }

            throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.Message);
        }
    }
        

    public virtual async Task<TEntity> CreateAsync(TEntity entity)
    {
        try
        {
            if (entity == default)
            {
                throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
            }

            ValidationResult validationResult = new CommonValidation<TEntity, UEntityId>().Validate(entity);
            if (!validationResult.IsValid)
                throw new ResponseMessageException().WithValidationResult(validationResult);
      

        
            var value = ListCommon.listCommon.Where(x => x.Code == entity.CollectionName).FirstOrDefault();
            if (value == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            _collection = (IMongoCollection<TEntity>)_context.GetCategoryCollectionAs(entity.CollectionName);
            if (_collection.CollectionNamespace.DatabaseNamespace == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);

            var model = _collection.Find(x => x.Code == entity.Code && !x.IsDeleted).FirstOrDefault();
            if (model != null)
                throw new ResponseMessageException().WithException(DefaultCode.DATA_EXISTED);
        
            entity.CreatedAt = DateTime.Now;
            entity.CreatedBy = CurrentUser != null ? CurrentUser.UserName : "CurrentUser Null";
            await _collection.InsertOneAsync(entity);
            if (entity.Id == null)
                throw new ResponseMessageException().WithException(DefaultCode.CREATE_FAILURE);
            return entity;
        } 
        catch (ResponseMessageException e)
        {
            throw new ResponseMessageException()
                .WithCode(DefaultCode.EXCEPTION)
                .WithMessage(e.ResultString)
                .WithDetail(e.Error);
        }
        catch (Exception e)
        {
            if (e.Message.Contains("is not a valid 24 digit hex string."))
            {
                throw new ResponseMessageException().WithException(DefaultCode.ID_NOT_CORRECT_FORMAT);
            }
            throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.Message);
        }
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity model)
    {
        try
        {
            if (model == default)
                throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
            
            
            ValidationResult validationResult = new CommonValidation<TEntity, UEntityId>().Validate(model);
            if (!validationResult.IsValid)
                throw new ResponseMessageException().WithValidationResult(validationResult);
            
            var value = ListCommon.listCommon.Where(x => x.Code == model.CollectionName).FirstOrDefault();
            if (value == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            _collection = (IMongoCollection<TEntity>)_context.GetCategoryCollectionAs(model.CollectionName);
            if (_collection.CollectionNamespace.DatabaseNamespace == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            var entity = _collection.Find(x => x.Id.Equals(model.Id) && !x.IsDeleted).FirstOrDefault();
            if (entity == default)
                throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
        
        
            var data_existed = _collection.Find(x => !x.Id.Equals(model.Id)  && x.Code.Equals(model.Code) && !x.IsDeleted).FirstOrDefault();
            if (data_existed != default)
                throw new ResponseMessageException().WithException(DefaultCode.DATA_EXISTED);
            model.ModifiedAt = DateTime.Now; 
            entity.ModifiedBy = CurrentUser != null ? CurrentUser.UserName : "CurrentUser Null";
            ReplaceOneResult actionResult
                = await _collection.ReplaceOneAsync(x => x.Id.Equals(model.Id)
                    , model
                    , new ReplaceOptions { IsUpsert = true });
            var result = actionResult.IsAcknowledged && actionResult.ModifiedCount > 0;
            if (!result)
                throw new ResponseMessageException().WithException(DefaultCode.UPDATE_FAILURE);
            return model;
        }
        catch (ResponseMessageException e)
        {
            throw new ResponseMessageException()
                .WithCode(DefaultCode.EXCEPTION)
                .WithMessage(e.ResultString)
                .WithDetail(e.Error);
        }
        catch (Exception e)
        {
            if (e.Message.Contains("is not a valid 24 digit hex string."))
            {
                throw new ResponseMessageException().WithException(DefaultCode.ID_NOT_CORRECT_FORMAT);
            }
            throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.Message);
        }
    }

    public virtual async Task DeleteAsync(TEntity model)
    {
        try
        {
            if (model == null || model.Id == null)
                throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
            var value = ListCommon.listCommon.Where(x => x.Code == model.CollectionName).FirstOrDefault();
            if (value == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            _collection = (IMongoCollection<TEntity>)_context.GetCategoryCollectionAs(model.CollectionName);
            if (_collection.CollectionNamespace.DatabaseNamespace == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            var entity = _collection.Find(x => x.Id.Equals(model.Id) && x.Code.Equals(model.Code) && !x.IsDeleted).FirstOrDefault();
            if (entity == default)
                throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
            entity.ModifiedAt = DateTime.Now;
            entity.ModifiedBy = CurrentUser != null ? CurrentUser.UserName : "CurrentUser Null";
            entity.IsDeleted = true;
            ReplaceOneResult actionResult
                = await _collection.ReplaceOneAsync(x => x.Id.Equals(entity.Id)
                    , entity
                    , new ReplaceOptions { IsUpsert = true });
            var result = actionResult.IsAcknowledged && actionResult.ModifiedCount > 0;
            if (!result)
                throw new ResponseMessageException().WithException(DefaultCode.DELETE_FAILURE);
        } 
        catch (ResponseMessageException e)
        {
            throw new ResponseMessageException()
                .WithCode(DefaultCode.EXCEPTION)
                .WithMessage(e.ResultString);
        }
        catch (Exception e)
        {
            if (e.Message.Contains("is not a valid 24 digit hex string."))
            {
                throw new ResponseMessageException().WithException(DefaultCode.ID_NOT_CORRECT_FORMAT);
            }
            throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.Message);
        }
     
    }

    public virtual async Task<dynamic> GetAsync(string collectionName)
    {
        try
        {
            var value = ListCommon.listCommon.Where(x => x.Code == collectionName).FirstOrDefault();
            if (value == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            _collectionCommon =(IMongoCollection<CommonModel>) _context.GetCategoryCollectionAs(collectionName);
            if (_collectionCommon.CollectionNamespace.DatabaseNamespace == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            var filter = Builders<CommonModel>.Filter.Where(x => !x.IsDeleted);
            var list = await _collectionCommon.Aggregate().Match(filter).SortByDescending(x=>x.Sort)
                .Project<CommonModelShort>(Projection.Projection_BasicCommon).ToListAsync();
            return list;
        }
        catch (ResponseMessageException e)
        {
            throw new ResponseMessageException()
                .WithCode(DefaultCode.EXCEPTION)
                .WithMessage(e.ResultString);
        }
        catch (Exception e)
        {
            if (e.Message.Contains("is not a valid 24 digit hex string."))
            {
                throw new ResponseMessageException().WithException(DefaultCode.ID_NOT_CORRECT_FORMAT);
            }
            throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.Message);
        }
    }



    public virtual async Task<dynamic> GetPagingAsync( CommonPaging param)
    {
        try
        {  
            PagingModel<dynamic> result = new PagingModel<dynamic>();
            var builder = Builders<CommonModel>.Filter;
            var filter = builder.Empty;
            if (String.IsNullOrEmpty(param.CollectionName))
                throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
            var value = ListCommon.listCommon.Where(x => x.Code == param.CollectionName).FirstOrDefault();
            if (value == null)
                throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
            _collectionCommon = (IMongoCollection<CommonModel>)_context.GetCategoryCollectionAs(value.Code);
            filter = builder.And(filter, builder.Where(x => !x.IsDeleted));
            if (!String.IsNullOrEmpty(param.Content))
            {
                filter = builder.And(filter,
                    builder.Where(x => x.Name.Trim().ToLower().Contains(param.Content.Trim().ToLower())
                                       || x.Code.Trim().ToLower().Contains(param.Content.Trim().ToLower())
                    ));
            }
            result.TotalRows = await _collectionCommon.CountDocumentsAsync(filter);
            string sortBy = param.SortBy != null ?  FormatterString.HandlerSortBy(param.SortBy) : "CreatedAt";
            result.Data  = await _collectionCommon.Find(filter)
                .Sort(param.SortDesc
                    ? Builders<CommonModel>
                        .Sort.Descending(sortBy).Descending("CreatedAt")
                    : Builders<CommonModel>
                        .Sort.Ascending(sortBy).Descending("CreatedAt"))
                .Project<CommonModelShort>(Projection.Projection_BasicCommon)
                .Skip(param.Skip)
                .Limit(param.Limit)
                .ToListAsync();
            return result;

        }
        catch (ResponseMessageException e)
        {
            throw new ResponseMessageException()
                .WithCode(DefaultCode.EXCEPTION)
                .WithMessage(e.ResultString);
        }
        catch (Exception e)
        {
            if (e.Message.Contains("is not a valid 24 digit hex string."))
            {
                throw new ResponseMessageException().WithException(DefaultCode.ID_NOT_CORRECT_FORMAT);
            }
            throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.Message);
        }
     
    }
}