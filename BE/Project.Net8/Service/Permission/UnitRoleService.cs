using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using DTC.DefaultRepository.Models.Core;
using DTC.MongoDB;

using MongoDB.Bson;
using MongoDB.Driver;
using Project.Net8.FromBodyModels;
using Project.Net8.Installers;
using Project.Net8.Interface.Permission;
using Project.Net8.Models.Core;
using Project.Net8.Models.Permission;
using Project.Net8.Service.Base;

namespace Project.Net8.Service.Permission
{
    public class UnitRoleService : BaseService, IUnitRoleService
    {
        private DataContext _context;
        private BaseMongoDb<UnitRole, string> BaseMongoDb;
        private BaseMongoDb<User, string> BaseMongoDbUser;
        private IMenuService _menuService;

        public UnitRoleService( DataContext context,
            IHttpContextAccessor contextAccessor,
            IMenuService menuService
            )
            : base(context, contextAccessor)
        {
            _context = context;
            BaseMongoDb = new BaseMongoDb<UnitRole, string>(_context.UNIT_ROLE);
        }

        public async Task<dynamic> Create(UnitRole model)
        {
            try
            {
                if (model == default) throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);

                var checkName = _context.UNIT_ROLE.Find(x => ( x.Name == model.Name || x.Code == model.Code) && !x.IsDeleted).FirstOrDefault();

                if (checkName != default) throw new ResponseMessageException().WithException(DefaultCode.DATA_EXISTED);
                
                
                var entity = new UnitRole
                {
                    Id = BsonObjectId.GenerateNewId().ToString(),
                    Name = model.Name,
                    Code = model.Code,
                    Sort = model.Sort,
            
                    CreatedAt = DateTime.Now,
                    CreatedBy = CurrentUserName,
                };
                var result = await BaseMongoDb.CreateAsync(entity);
                if (result.Entity.Id == default || !result.Success)
                    throw new ResponseMessageException().WithException(DefaultCode.CREATE_FAILURE);
                
                
                return new UnitRoleShort(entity);
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
        public async Task<dynamic> Update(UnitRole model)
        {
            try
            {
                if (model == default)  throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);

            var entity = _context.UNIT_ROLE.Find(x => x.Id == model.Id).FirstOrDefault();
            if (entity == default) throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

            
            var checkName = _context.UNIT_ROLE.Find(x => x.Id != model.Id
                                                            && x.Name.ToLower() == model.Name.ToLower()
                                                            && !x.IsDeleted 
            ).FirstOrDefault();
            
            if (checkName != default) throw new ResponseMessageException().WithException(DefaultCode.DATA_EXISTED);

            

            entity.Name = model.Name;
            entity.Code = model.Code;
            entity.Sort = model.Sort;
         
            entity.ModifiedAt = DateTime.Now;
            entity.CreatedBy = CurrentUserName;
            var result = await BaseMongoDb.UpdateAsync(entity);
            if (!result.Success)
                throw new ResponseMessageException().WithException(DefaultCode.UPDATE_FAILURE);

            return new UnitRoleShort(entity);
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
        
        
        //   Lay quyen dua theo username 
    
        
        public async Task<dynamic> UpdateAction(IdFromBodyUnitRole model)
        {
            try
            { 
                if (model == default)  throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
            var entity = _context.UNIT_ROLE.Find(x => !x.IsDeleted && x.Id == model.Id).FirstOrDefault();
           
            
            if (entity == default) throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
            
            if (model.ListAction != null && model.ListAction.Count > 0 )
            {
                entity.ListMenu.Clear();
                entity.ListAction.Clear();
                foreach (var item in model.ListAction)
                {
                    if(item == null)
                        continue;
                    var action = item.Split("-");
                    if(action[1].Equals(""))
                        continue;
                    var key = entity.ListMenu.Where(x => x == action[1]).FirstOrDefault();
                    if (key == null)
                    {
                        entity.ListMenu.Add(action[1]);
                    }
                    entity.ListAction.Add(item);
                }
            }
            else
            {
                entity.ListMenu.Clear();
                entity.ListAction.Clear();
            }
            entity.ModifiedAt = DateTime.Now;
            entity.ModifiedBy = CurrentUserName;
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

        public async Task<dynamic> UpdateController(UnitRole model)
        {
            try
            { 
                if (model == default)  throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
                var entity = _context.UNIT_ROLE.Find(x => !x.IsDeleted && x.Id == model.Id).FirstOrDefault();
           
            
                if (entity == default) throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

             

                //entity.Controll
                
                
                entity.Controller = model.Controller;
                entity.ModifiedAt = DateTime.Now;
                entity.ModifiedBy = CurrentUserName;
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
        
        
        
        
    }
    
}