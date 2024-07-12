using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using DTC.MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using Project.Net8.Installers;
using Project.Net8.Interface.Permission;
using Project.Net8.Models.Permission;
using Project.Net8.Service.Base;

namespace Project.Net8.Service.Permission
{
    public class APIService : BaseService, IAPIService
    {
        private DataContext _context;
        private BaseMongoDb<APIModel, string> BaseMongoDb;
        private BaseMongoDb<UnitRole, string> BaseMongoDbUnitRole;
        public APIService(
            DataContext context,
            IHttpContextAccessor contextAccessor) :
            base(context, contextAccessor)
        {
            _context = context;
            BaseMongoDb = new BaseMongoDb<APIModel, string>(_context.API);
            BaseMongoDbUnitRole = new BaseMongoDb<UnitRole, string>(_context.UNIT_ROLE);
        }

        public async Task<dynamic> Create(APIModel model)
        {
            try
            {
                if (model == default)
                throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
            
            var menu = _context.MENU.Find(x => !x.IsDeleted &&  (x.Name == model.Name || x.Resource == FormatterString.
                ConvertToUnsign(model.Name).
                Replace(" ",""))).FirstOrDefault();
            if (menu != default)
            {
                throw new ResponseMessageException()
                    .WithException(DefaultCode.DATA_EXISTED);
            }
            /*ValidationResult validationResult = new MenuValidation().Validate(model);
            if (!validationResult.IsValid)         
                throw new ResponseMessageException().WithValidationResult(validationResult);     */
            var entity = new APIModel()
            {
                Id = BsonObjectId.GenerateNewId().ToString(),
                Name = model.Name,
            };
            entity.SetListAction();
            var result = await BaseMongoDb.CreateAsync(entity);
            if (result.Entity.Id == default || !result.Success)
            {
                throw new ResponseMessageException()
                    .WithException(DefaultCode.CREATE_FAILURE);
            }
            return entity;
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString)
                    .WithDetail(e.Error);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("is not a valid 24 digit hex string."))
                {
                    throw new ResponseMessageException().WithException(DefaultCode.ID_NOT_CORRECT_FORMAT);
                }
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(ex.Message);
            }
        }
        
           public async Task<dynamic> Update(APIModel model)
        {
            try{
            if (model == default)
                throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
            var entity = _context.API.Find(x => !x.IsDeleted && x.Id == model.Id).FirstOrDefault();
            if (entity == default)
                throw new ResponseMessageException()
                    .WithException(DefaultCode.DATA_NOT_FOUND);
            
            var checkName = _context.API.Find(x => !x.IsDeleted &&
                                                    x.Id != model.Id
                                                    && (x.Name == model.Name || x.UnsignedName ==
                                                        FormatterString.ConvertToUnsign(model.Name).Replace(" " ,""))
            ).FirstOrDefault();
            /*ValidationResult validationResult = new MenuValidation().Validate(model);
            if (!validationResult.IsValid)
                throw new ResponseMessageException().WithValidationResult(validationResult);*/
            

            if (checkName != default)
                throw new ResponseMessageException().WithException(DefaultCode.DATA_EXISTED);
            
            if (!model.Name.Equals(entity.Name))
            {
                model.ListAction = new List<string>();
                foreach (var item in entity.ListAction)
                {
                    var data = item.Split("/");
                    if (data != null && data.Length > 1)
                    {
                        model.ListAction.Add(model.Name + "/" + data[1]);
                    }
                }
                entity.ListAction = model.ListAction;

                var  listRole =
                    _context.UNIT_ROLE.Find(x=> x.Controller.Any(x=>x.key == entity.Name)).ToList();

                if (listRole != null)
                {
                    foreach (var unitRole in listRole)
                    {
                        var index  = unitRole.Controller.FindIndex(x => x.key == entity.Name);
                        if (index >= 0)
                        {
                            unitRole.Controller[index].key = model.Name;
                            var resultUnitRole = await BaseMongoDbUnitRole.UpdateAsync(unitRole);
                        }

                        
                    }
                }
               
                
                
            }
            
            entity.Name = model.Name;
            entity.Sort = model.Sort;
            entity.ModifiedAt = DateTime.Now;
            
            var result = await BaseMongoDb.UpdateAsync(entity);
            if (!result.Success)
                throw new ResponseMessageException().WithException(DefaultCode.UPDATE_FAILURE);
            return entity;
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.ResultString).WithDetail(e.Error);
            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }

           
           
           
        
           public async Task<dynamic> AddAC(MenuList model)
           {
               if (model == null || _context.API == null)
                   throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

               var entity = await _context.API.Find(x => !x.IsDeleted && x.Id == model.Id).FirstOrDefaultAsync();

               if (entity == null)
                   throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

               var actionName =  entity.Name + "/" +  model.Action ;

               if (entity.ListAction.Contains(actionName))
                   throw new ResponseMessageException().WithException(DefaultCode.DATA_EXISTED);

               entity.ListAction.Add(actionName);
            
               var filter = Builders<APIModel>.Filter.Where(x => !x.IsDeleted &&  x.Id == model.Id);
               var update = Builders<APIModel>.Update.Set(x => x.ListAction, entity.ListAction);
               var result = await _context.API.UpdateOneAsync(filter, update);
               if (result.MatchedCount == 0)
               {
                   throw new ResponseMessageException()
                       .WithCode(DefaultCode.DATA_NOT_FOUND)
                       .WithMessage(DefaultMessage.DATA_NOT_FOUND);
               }

               return entity.ListAction;
           }

           public async Task<dynamic> DeleteAc(MenuList model)
           {
               try
               {
                   if (model == default)
                       throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);

                   var filter = Builders<Menu>.Filter.Where(x => x.Id == model.Id);
                   var entity = await _context.API
                       .Find(x => !x.IsDeleted && x.Id == model.Id)
                       .FirstOrDefaultAsync();

                   if (entity == null)
                       throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

                       entity.ListAction.Remove(model.Action);
                       
                       var result = await BaseMongoDb.UpdateAsync(entity);
                       if (!result.Success)
                           throw new ResponseMessageException().WithException(DefaultCode.UPDATE_FAILURE);
                       return entity;
               }
               catch (ResponseMessageException e)
               {
                   throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.ResultString)
                       .WithDetail(e.Error);
               }
               catch (Exception e)
               {
                   throw ExceptionError.Exception(e);
               }
           }

           public async Task<dynamic> Get()
           {
               var list = _context.API.Find(x => !x.IsDeleted).ToList();

               foreach (var item in list)
               {
                   var listABC = new List<string>();
                   foreach (var listString in item.ListAction)
                   { 
                       
                       var abc = listString.Split("/");
                       
                       listABC.Add(abc[1].Trim());
                   }

                   item.ListAction = listABC;
                   var result = await BaseMongoDb.UpdateAsync(item);
               }

               return null;
           }
    }
}