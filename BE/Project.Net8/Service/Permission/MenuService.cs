using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using DTC.MongoDB;
using FluentValidation.Results;
using MongoDB.Bson;
using MongoDB.Driver;
using Project.Net8.Constants;
using Project.Net8.Installers;
using Project.Net8.Interface.Permission;
using Project.Net8.Models.Permission;
using Project.Net8.Service.Base;
using Project.Net8.ViewModels;

namespace Project.Net8.Service.Permission
{
    public class MenuService : BaseService, IMenuService
    {
        private DataContext _context;
        private BaseMongoDb<Menu, string> BaseMongoDb;
        private BaseMongoDb<UnitRole, string> BaseMongoDbUnitRole;
        public MenuService(
            DataContext context,
            IHttpContextAccessor contextAccessor) :
            base(context, contextAccessor)
        {
            _context = context;
            BaseMongoDb = new BaseMongoDb<Menu, string>(_context.MENU);
        }

        public async Task<dynamic> Create(Menu model)
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
            ValidationResult validationResult = new MenuValidation().Validate(model);
            if (!validationResult.IsValid)         
                throw new ResponseMessageException().WithValidationResult(validationResult);     
            var entity = new Menu
            {
                Id = BsonObjectId.GenerateNewId().ToString(),
                Name = model.Name,
                Path = model.Path,
                Icon = model.Icon,
                Resource = CommonFormat.GenerateNewRandomDigit(),
                ParentId = model.ParentId,
                Sort = model.Sort,
                CreatedAt = DateTime.Now,
                IsDeleted = false,
                Action = model.Action,
            };
            if (model.ParentId != null)
            {
                var level = _context.MENU.Find(x => x.Id == model.ParentId).FirstOrDefault();
                if (level == null)
                    throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage("Đơn vị cha không đúng !");
                entity.Level= level.Level + 1; 
            }
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


        #region Cap Nhat Menu 

        public async Task<dynamic> Update(Menu model)
        {
            try
            {
                if (model == default)
                    throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
                var entity = _context.MENU.Find(x => !x.IsDeleted && x.Id == model.Id).FirstOrDefault();
                if (entity == default)
                    throw new ResponseMessageException()
                        .WithException(DefaultCode.DATA_NOT_FOUND);
            
                var checkName = _context.MENU.Find(x => !x.IsDeleted &&
                                                        x.Id != model.Id
                                                        && (x.Name == model.Name || x.Resource ==
                                                            FormatterString.ConvertToUnsign(model.Name).Replace(" " ,""))
                ).FirstOrDefault();
                ValidationResult validationResult = new MenuValidation().Validate(model);
                if (!validationResult.IsValid)
                    throw new ResponseMessageException().WithValidationResult(validationResult);
            

                if (checkName != default)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_EXISTED);

                entity.Name = model.Name;
                entity.Path = model.Path;
                entity.Icon = model.Icon;
                entity.ParentId = model.ParentId;
                entity.Level = model.Level;
                entity.Sort = model.Sort;
                entity.ModifiedAt = DateTime.Now;
                entity.Action = model.Action;

                if (model.ParentId != null)
                {
                    var menu = _context.MENU.Find(x => x.Id == model.ParentId).FirstOrDefault();
                    if (menu == null)
                        throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage("Đơn vị cha không đúng !");
                    entity.Level= menu.Level + 1; 
                }
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
                if (e.Message.Contains("is not a valid 24 digit hex string."))
                {
                    throw new ResponseMessageException().WithException(DefaultCode.ID_NOT_CORRECT_FORMAT);
                }
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION).WithMessage(e.Message);
            }
        }
           

        #endregion
     
        public async Task<List<MenuTreeVM>> GetTreeList()
        {
            var listDonVi = await _context.MENU.Find(_ => _.IsDeleted != true).SortByDescending(donVi => donVi.Sort).ToListAsync();
            var parents = listDonVi.Where(x => x.ParentId == null || x.ParentId.Equals("")).OrderByDescending(x=>x.Sort).ToList();
            List<MenuTreeVM> list = new List<MenuTreeVM>();
            foreach (var item in parents)
            {
                MenuTreeVM donVi = new MenuTreeVM(item);
                list.Add(donVi);
                GetLoopItem(ref list, listDonVi, donVi);
            }
            return list;
        }
        private List<MenuTreeVM> GetLoopItem(ref List<MenuTreeVM> list, List<Menu> items, MenuTreeVM target)
        {
            
            var menu =  items.Where(x=>x.ParentId == target.Id).OrderBy(x=>x.Sort).ToList();
            if (menu.Count > 0)
            {
                target.Children = new List<MenuTreeVM>();
                foreach (var item in menu)
                {
                    MenuTreeVM itemDV = new MenuTreeVM(item);
                    target.Children.Add(itemDV);
                    // target.SubItems.Add(itemDV);
                    GetLoopItem(ref list, items, itemDV);
                }
            }
            return null;
        }
        

        public async Task<dynamic> AddAC(MenuList model)
        {
            if (model == null || _context.MENU == null)
                throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

            var entity = await _context.MENU.Find(x => !x.IsDeleted && x.Id == model.Id).FirstOrDefaultAsync();

            if (entity == null)
                throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

            var actionName =  model.Action + "-" +  entity.Resource ;

            if (entity.ListAction.Contains(actionName))
                throw new ResponseMessageException().WithException(DefaultCode.DATA_EXISTED);

            entity.ListAction.Add(actionName);
            
            var filter = Builders<Menu>.Filter.Where(x => !x.IsDeleted &&  x.Id == model.Id);
            var update = Builders<Menu>.Update.Set(x => x.ListAction, entity.ListAction);
            var result = await _context.MENU.UpdateOneAsync(filter, update);
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
                var entity = await _context.MENU
                    .Find(x => !x.IsDeleted && x.Id == model.Id)
                    .FirstOrDefaultAsync();

                if (entity == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

                if (entity.ListAction != null)
                {
                    entity.ListAction.Remove(model.Action);
                    var update = Builders<Menu>.Update.Set(x => x.ListAction, entity.ListAction);
                    var result = await _context.MENU.UpdateOneAsync(filter, update);

                    if (result.IsAcknowledged && result.ModifiedCount > 0)
                    {
                        var updatedEntity = await _context.MENU
                            .Aggregate()
                            .Match(filter)
                            .SortByDescending(x => x.Sort)
                            .ToListAsync();

                        return updatedEntity;
                    }
                    else
                    {
                        throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
                    }
                }
                else
                {
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);
                }
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
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
        public async Task<dynamic> UpdateMenuAction()
        {

            /*var abc = _context.MENU.Find(x => !x.IsDeleted ).ToList();
            foreach (var item in abc)
             {

                 item.Resource = CommonFormat.GenerateNewRandomDigit();
                 item.SetListAction();
                var result = await BaseMongoDb.UpdateAsync(item);
            }*/

            return null;
        }


        public async Task<List<NavMenuVM>> GetTreeListMenuForCurrentUser(List<Menu> listMenu)
        {
            var parents = listMenu.Where(x => x.ParentId == null).OrderBy(x=>x.Sort).ToList();
            List<NavMenuVM> list = new List<NavMenuVM>();
            foreach (var item in parents) 
            {
                if (item != null && item.Id != null)
                {
                    NavMenuVM menu = new NavMenuVM(item);
                    list.Add(menu);
                    item.IsChecked = true;
                    UpdateMenu(listMenu, item);
                    GetLoopItemSubItems(ref list, listMenu, menu);  
                }
             
            }
            var remaining = listMenu.Where(x => x.IsChecked == false).ToList();
            foreach (var item in remaining) 
            {
                if (item != null && item.Id != null)
                {
                    NavMenuVM menu = new NavMenuVM(item);
                    list.Add(menu);
                    item.IsChecked = true;
                    UpdateMenu(listMenu, item);
                    GetLoopItemSubItems(ref list, listMenu, menu);
                        
                }
              
            }
            return list;
        }
        
        
        
        
        public async Task<List<NavMenuVM>> GetTreeListMenuAll()
        {

            var listMenu = await _context.MENU.Find(_ => _.IsDeleted != true).SortByDescending(donVi => donVi.Sort).ToListAsync();
            var parents = listMenu.Where(x => x.ParentId == null || x.ParentId.Equals("")).OrderByDescending(x=>x.Sort).ToList();
            
            List<NavMenuVM> list = new List<NavMenuVM>();
            foreach (var item in parents)
            {
                NavMenuVM menu = new NavMenuVM(item);
                list.Add(menu);
                GetLoopItemSubItems(ref list, listMenu, menu);
            }
            return list;
        }
        
        
        private async Task<List<Menu>> UpdateMenu(List<Menu> list , Menu menu )
        {

            int index = list.FindIndex(x => x.Id == menu.Id);
            list[index] = menu;
            return list;
        }


        
        private List<MenuTreeVM> GetLoopItemSubItems(ref List<NavMenuVM> listMenuVM, List<Menu> listMenu, NavMenuVM target)
        {
            var parents = listMenu.Where(x => x.ParentId == target.Id && !x.IsDeleted).OrderBy(x=>x.Sort).ToList();
            if (parents.Count == 0)
                return null;
            List<NavMenuVM> list = new List<NavMenuVM>();
            foreach (var item in parents)
            {
                if (target.Children == default)
                    target.Children = new List<NavMenuVM>();
                if (item != null && item.Id != null)
                {
                    NavMenuVM donVi = new NavMenuVM(item);
                    item.IsChecked = true;
                    UpdateMenu(listMenu, item);
                    target.Children.Add(donVi);
                    GetLoopItemSubItems(ref list, listMenu, donVi);  
                }
             
            }
            return null;
        }
        
        
        public async Task<dynamic> GetTreeFlatten()
        {
            List<MenuTreeVMGetAll> list = new List<MenuTreeVMGetAll>();
         
            var listDonVi = await _context.MENU.Find(x  => !x.IsDeleted).ToListAsync();
            var parents = listDonVi.Where(x => x.ParentId == null || x.ParentId.Equals("")).ToList();
            var listId = new List<String>();
            foreach (var item in parents)
            {
                    
                MenuTreeVMGetAll donVi = new MenuTreeVMGetAll(item);
                list.Add(donVi);
                GetLoopItemGetAll(ref list,listDonVi, donVi);
            }
            return list;
        }
        
        
        private void  GetLoopItemGetAll(ref List<MenuTreeVMGetAll> list, List<Menu> items, MenuTreeVMGetAll target)
        {
            try
            {
                var coquan = items.FindAll((item) => item.ParentId == target.Id).OrderBy(x=>x.Name).ToList();
                if (coquan.Count > 0)
                {
                    foreach (var item in coquan)
                    {
                        MenuTreeVMGetAll itemDV = new MenuTreeVMGetAll(item);
                        list.Add(itemDV);
                        GetLoopItemGetAll(ref list, items, itemDV);
                    }
                }
            }
            catch (ResponseMessageException e)
            {
                throw new ResponseMessageException()
                    .WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(e.ResultString);
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





    }
}