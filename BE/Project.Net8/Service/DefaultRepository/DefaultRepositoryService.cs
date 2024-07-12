using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.FromBodyModels;
using DTC.DefaultRepository.Helpers;
using DTC.DefaultRepository.Models.Core;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Project.Net8.Constants;
using Project.Net8.FromBodyModels;
using Project.Net8.Installers;
using Project.Net8.Interface.DefaultRepository;
using Project.Net8.Models.Core;
using Project.Net8.Models.PagingParam;
using Project.Net8.Models.Permission;
using Project.Net8.Service.Base;

namespace Project.Net8.Service.DefaultRepository
{
    public class DefaultReposityService<T> : BaseService ,IDefaultReposityService<T> where T  : class
    {
        protected IMongoCollection<T> _collection ;

        protected ProjectionDefinition<T, BsonDocument> projectionSelected = Builders<T>.Projection
            .Include("Id")
            .Include("Name");



        protected ProjectionDefinition<T, BsonDocument> projectionDefinition = Builders<T>.Projection
            .Exclude("CreatedAt")
            .Exclude("ModifiedAt")
            .Exclude("CreatedBy")
            .Exclude("ModifiedBy")
            .Exclude("IsDeleted")
            .Exclude("PasswordSalt")
            .Exclude("PasswordHash")
            .Exclude("DataIds")
            .Exclude("KCCNIds")
            .Exclude("ListMenu")
            .Exclude("CreatedAtString")
            .Exclude("UnsignedName");
        
        
        
        private readonly IHttpContextAccessor _contextAccessor;
        protected readonly DataContext _context;
      
        private User _user;
        
        
        
        
        public DefaultReposityService(IMongoCollection<T> collection , DataContext dataContext,IHttpContextAccessor contextAccessor )
        {
            _collection = collection;
            _context = dataContext;
            _contextAccessor = contextAccessor;
            var userId = _contextAccessor.HttpContext.User?.Claims.FirstOrDefault(x => x.Type == ListActionDefault.KeyId)?.Value;
            _user = _context.USERS.Find(x => x.Id == userId).FirstOrDefault();
        }



        #region GETALL

         public async Task<dynamic> GetAll()
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("IsDeleted", false);
                var listBson = await _collection.Find(filter)
                  .Sort(Builders<T>
                      .Sort.Descending("CreatedAt"))
                  .Project(projectionDefinition)
                  .ToListAsync();
              
              if (listBson == null)
                return null;
            var data =   listBson.Select(x => BsonSerializer.Deserialize<T>(x)).ToList();

            return data; 
          }
            catch (ResponseMessageException e) {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }
        
         

        #endregion

        
        
        
       
        
        
        public async Task<dynamic> GetAllSelected()
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("IsDeleted", false);
                var listBson = await _collection.Find(filter)
                    .Sort(Builders<T>
                        .Sort.Descending("CreatedAt"))
                    .Project(projectionSelected)
                    .ToListAsync();
                if (listBson == null)
                    return null;
                var data =   listBson.Select(x => BsonSerializer.Deserialize<CoreModel>(x)).ToList();
                return data; 
            }
            catch (ResponseMessageException e) {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }
        
   

        
        
        public async Task<dynamic> GetAllSelectedByCode(string code , string properties)
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("IsDeleted", false);
                filter = Builders<T>.Filter.And(filter, Builders<T>.Filter.Eq(properties, code));
                var listBson= await _collection.Find(filter).Sort(Builders<T>.Sort.Descending("CreatedAt"))
                    .Project(projectionSelected)
                    .ToListAsync();
                if (listBson == null)
                    return null;
                var data =   listBson.Select(x => BsonSerializer.Deserialize<CoreModel>(x)).ToList();
                if (data == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
                return data;
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }

        
        
        public async Task<dynamic> GetById(IdFromBodyModel fromBodyModel)
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("IsDeleted", false);
                filter = Builders<T>.Filter.And(filter, Builders<T>.Filter.Eq("Id", fromBodyModel.Id));
                dynamic data = await _collection.Find(filter).FirstOrDefaultAsync();
                if (data == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
                
                return data;
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }
        
        
      

        public async Task<bool> Delete(IdFromBodyModel fromBodyModel) 
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("IsDeleted", false);
                filter = Builders<T>.Filter.And(filter, Builders<T>.Filter.Eq("Id", fromBodyModel.Id));
                dynamic data =  await _collection.Find(filter).FirstOrDefaultAsync();
                if (data == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
                data.IsDeleted = true;
                var result =  _collection.ReplaceOne(filter, data, new UpdateOptions() { IsUpsert = true } );
                if (result.ModifiedCount  ==   0  || result == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DELETE_FAILURE);
                return true;
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }
        
        
        public async Task<bool> Deleted(IdFromBodyModel fromBodyModel) 
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("IsDeleted", false);
                filter = Builders<T>.Filter.And(filter, Builders<T>.Filter.Eq("Id", fromBodyModel.Id));
                dynamic data =  await _collection.Find(filter).FirstOrDefaultAsync();
                if (data == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
            
            
                var result = await _collection.DeleteOneAsync(filter);
                if (!result.IsAcknowledged || result.DeletedCount <= 0)
                    throw new ResponseMessageException().WithException(DefaultCode.DELETE_FAILURE);
                return true;
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }


        public async Task<dynamic> GetPagingCore(PagingParamDefault pagingParam)
        {
            try
            {
                PagingModel<dynamic> result = new PagingModel<dynamic>();
                var builder = Builders<T>.Filter;
                var filter = builder.Empty;
                filter = builder.And(filter, builder.Eq("IsDeleted", false));

                
                
                if (!String.IsNullOrEmpty(pagingParam.Content))
                {
                    filter = builder.And(filter,
                        (builder.Regex("TenCongViec", FormatterString.ConvertToUnsign(pagingParam.Content)) |
                         
                         builder.Regex("MoTa", FormatterString.ConvertToUnsign(pagingParam.Content)) |

                         builder.Regex("Name", FormatterString.ConvertToUnsign(pagingParam.Content)) |

                         builder.Regex("Ten", FormatterString.ConvertToUnsign(pagingParam.Content)) |                         
                         
                         builder.Regex("Code", pagingParam.Content) 
                        ));
                }
                       
                result.TotalRows = await _collection.CountDocumentsAsync(filter);

                string sortBy = pagingParam.SortBy != null
                    ? FormatterString.HandlerSortBy(pagingParam.SortBy)
                    : "CreatedAt";
                var list = await _collection.Find(filter)
                    .Sort(pagingParam.SortDesc
                        ? Builders<T>
                            .Sort.Descending(sortBy).Descending("CreatedAt")
                        : Builders<T>
                            .Sort.Ascending(sortBy).Descending("CreatedAt"))
                    .Skip(pagingParam.Skip)
                    .Limit(pagingParam.Limit)
                    .Project(projectionDefinition)
                    .ToListAsync();

                result.Data = list.Select(x => BsonSerializer.Deserialize<T>(x)).ToList();

                return result;

            }
            catch (ResponseMessageException e)
            {
                new ResultMessageResponse().WithCode(e.ResultCode)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }

            return null;

        }






        public async Task<dynamic> GetAllPagingCore(PagingParamDefault pagingParam)
        {
            try
            {
                PagingModel<dynamic> result = new PagingModel<dynamic>();
                var builder = Builders<T>.Filter;
                var filter = builder.Empty;
                filter = builder.And(filter, builder.Eq("IsDeleted", false));
                if (!String.IsNullOrEmpty(pagingParam.Content))
                {
                    filter = builder.And(filter,
                        (builder.Regex("UnsignedName", FormatterString.ConvertToUnsign(pagingParam.Content)) |
                         builder.Regex("Code", pagingParam.Content) 
                        ));
                }
            
                string sortBy = pagingParam.SortBy != null ? FormatterString.HandlerSortBy(pagingParam.SortBy) : "CreatedAt";
                var list = await _collection.Find(filter)
                    .Sort(pagingParam.SortDesc
                        ? Builders<T>
                            .Sort.Descending(sortBy).Descending("CreatedAt")
                        : Builders<T>
                            .Sort.Ascending(sortBy).Descending("CreatedAt"))
                    .Project(projectionSelected)
                    .ToListAsync();
                
                
             var data =   list.Select(x => BsonSerializer.Deserialize<CoreModel>(x)).ToList();
             return data;
            }
            catch (ResponseMessageException e)
            {
                new ResultMessageResponse().WithCode(e.ResultCode)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
            return null;
        }

        
        
        
        
        public async Task<dynamic> GetListDataByProperties(IdFromBodyModel fromBodyModel, string properties)
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("IsDeleted", false);
                filter = Builders<T>.Filter.And(filter, Builders<T>.Filter.Eq(properties, fromBodyModel.Id));
                dynamic data = await _collection.Find(filter).Sort(Builders<T>.Sort.Descending("CreatedAt"))
                    .ToListAsync();
                if (data == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
                return data;
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }
        
        
        

        public async Task<dynamic> GetFirtstDataByProperties(IdFromBodyModel fromBodyModel, string properties)
        {
            try
            {
                var filter = Builders<T>.Filter.Eq("IsDeleted", false);
                filter = Builders<T>.Filter.And(filter, Builders<T>.Filter.Eq(properties, fromBodyModel.Id));
                dynamic data = await _collection.Find(filter).Sort(Builders<T>.Sort.Descending("CreatedAt"))
                    .FirstOrDefaultAsync();
                if (data == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
                return data;
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }
        
    }
    
    
}
