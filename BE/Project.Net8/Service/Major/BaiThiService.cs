using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using DTC.MongoDB;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using Project.Net8.Constants;
using Project.Net8.Installers;
using Project.Net8.Interface.Major;
using Project.Net8.Models.Core;
using Project.Net8.Models.Major;
using Project.Net8.Models.PagingParam;
using Project.Net8.Service.Base;
using Project.Net8.ViewModels;
using System.Collections;

namespace Project.Net8.Service.Major
{
    public class BaiThiService : BaseService, IBaiThiService
    {
        private DataContext _context;
        private BaseMongoDb<BaiThiModel, string> BaseMongoDb;
        protected IMongoCollection<CommonModel> _collectionCommon;        
        protected ProjectionDefinition<BaiThiModel, BsonDocument> projectionDefinition = Builders<BaiThiModel>.Projection
            .Exclude("ModifiedAt")
            .Exclude("CreatedBy")
            .Exclude("ModifiedBy")
            .Exclude("IsDeleted")
            .Exclude("CreatedAtString")
            .Exclude("PasswordSalt")
            .Exclude("PasswordHash")
            .Exclude("Sort")
            .Exclude("UnsignedName");
        public BaiThiService(
            DataContext context,
            IHttpContextAccessor contextAccessor) :
            base(context, contextAccessor)
        {
            _context = context;
            BaseMongoDb = new BaseMongoDb<BaiThiModel, string>(_context.BAITHI);
        }


        public async Task<dynamic> Update(BaiThiModel model)
        {
            try
            {
                if (model == default)
                    throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);

                var entity = await _context.BAITHI.Find(x => !x.IsDeleted && x.Id == model.Id).FirstOrDefaultAsync();
                if (entity == null)
                    throw new ResponseMessageException().WithException(DefaultCode.DATA_NOT_FOUND);

                entity.Name = model.Name;
                entity.MoTaCongViec = model.MoTaCongViec;
                entity.ThoiGianBatDau = model.ThoiGianBatDau;
                entity.ThoiGianKetThuc = model.ThoiGianKetThuc;
                entity.NguoiGiao = model.NguoiGiao;
                entity.NguoiThucHien = model.NguoiThucHien;
                entity.TrangThai = model.TrangThai;
                entity.ParentId = model.ParentId;
                entity.Files = model.Files;

                entity.ModifiedAt = DateTime.Now;
                entity.ModifiedBy = CurrentUserName;
                var result = await BaseMongoDb.UpdateAsync(entity);
                if (result.Entity.Id == default || !result.Success)
                    throw new ResponseMessageException().WithException(DefaultCode.CREATE_FAILURE);

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

        public async Task<dynamic> Create(BaiThiModel model)
        {
            try
            {
                if (model == default)
                    throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
                if(model.TrangThai == null)
                {
                    _collectionCommon = (IMongoCollection<CommonModel>)_context.GetCategoryCollectionAs("DM_TRANGTHAI");
                    if (_collectionCommon.CollectionNamespace.DatabaseNamespace == null)
                        throw new ResponseMessageException().WithException(DefaultCode.COMMON_NOT_FOUND);
                    var filter = Builders<CommonModel>.Filter.Where(x => !x.IsDeleted && x.Code == "3");
                    var item = await _collectionCommon.Aggregate().Match(filter).SortByDescending(x => x.Sort)
                        .Project<CommonModelShort>(Projection.Projection_BasicCommon).FirstOrDefaultAsync();
                    var CommonModelShort = new CommonModelShort()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Code = item.Code
                    };
                    model.TrangThai = CommonModelShort;
                }
                var user = new ModelShort()
                {
                    Id = CurrentUser.Id, 
                    Name = CurrentUser.Name,
                };
                model.NguoiGiao = user;

                var result = await BaseMongoDb.CreateAsync(model);
                if (result.Entity.Id == default || !result.Success)
                    throw new ResponseMessageException().WithException(DefaultCode.CREATE_FAILURE);

                return model;
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

        public async Task<dynamic> GetPagingCore(PagingParamDefault pagingParam)
        {
            try
            {
                PagingModel<dynamic> result = new PagingModel<dynamic>();
                var builder = Builders<BaiThiModel>.Filter;
                var filter = builder.Empty;
                filter = builder.And(filter, builder.Eq("IsDeleted", false));

                if (!String.IsNullOrEmpty(pagingParam.Content))
                {
                    var unsignedContent = FormatterString.ConvertToUnsign(pagingParam.Content);
                    filter = builder.And(filter, (
                             builder.Regex("UnsignedName", FormatterString.ConvertToUnsign(pagingParam.Content))
                             ));
                }

                if (pagingParam.TrangThai != null && !pagingParam.TrangThai.Equals(""))
                {
                    filter = builder.And(filter,
                        builder.Where(x => x.TrangThai.Code == pagingParam.TrangThai)
                    );
                }

                if (pagingParam.UserTake)
                {
                    filter = builder.And(filter,
                        builder.Where(x => x.NguoiThucHien.Any(y => y.Id == CurrentUser.Id))
                    );
                }

                if (pagingParam.Date)
                {
                    filter = builder.And(filter,
                        builder.Where(x => x.ThoiGianBatDau <= DateTime.Now && x.ThoiGianKetThuc >= DateTime.Now)
                    );
                }

                result.TotalRows = await _context.BAITHI.CountDocumentsAsync(filter);

                string sortBy = pagingParam.SortBy != null
                    ? FormatterString.HandlerSortBy(pagingParam.SortBy)
                    : "CreatedAt";
                var list = await _context.BAITHI.Find(filter)
                    .Sort(pagingParam.SortDesc
                        ? Builders<BaiThiModel>
                            .Sort.Descending(sortBy).Descending("CreatedAt")
                        : Builders<BaiThiModel>
                            .Sort.Ascending(sortBy).Descending("CreatedAt"))
                    .Skip(pagingParam.Skip)
                    .Limit(pagingParam.Limit)
                    .Project(projectionDefinition)
                    .ToListAsync();

                result.Data = list.Select(x => BsonSerializer.Deserialize<BaiThiModel>(x)).ToList();

                return result;

            }
            catch (Exception e)
            {
                throw ExceptionError.Exception(e);
            }
        }

        public async Task<dynamic> GetTreeAll()
        {
            List<BaiThiTreeVM> list = new List<BaiThiTreeVM>();

            var listDonVi = await _context.BAITHI.Find(x => x.IsDeleted == false).SortBy(x => x.Name).ToListAsync();
            var parents = listDonVi.Where(x => x.ParentId == null).ToList();
            var listId = new List<String>();
            foreach (var item in parents)
            {

                BaiThiTreeVM donVi = new BaiThiTreeVM(item);
                list.Add(donVi);
                GetLoopItem(ref list, listDonVi, donVi);

            }
            return list;
        }

        private List<BaiThiTreeVM> GetLoopItem(ref List<BaiThiTreeVM> list, List<BaiThiModel> items, BaiThiTreeVM target)
        {
            try
            {
                var coquan = items.FindAll((item) => item.ParentId == target.Id).OrderBy(x => x. Name).ToList();
                if (coquan.Count > 0)
                {
                    target.Children = new List<BaiThiTreeVM>();
                    foreach (var item in coquan)
                    {
                        BaiThiTreeVM itemDV = new BaiThiTreeVM(item);
                        target.Children.Add(itemDV);
                        GetLoopItem(ref list, items, itemDV);
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
            return null;
        }

        public async Task<dynamic> GetListById(string id)
        {
            var congViec = await _context.BAITHI.Find(x => x.IsDeleted == false && x.Id == id).FirstOrDefaultAsync();
            if (congViec != null)
            {
                var congViecCon = _context.BAITHI.Find(x => x.ParentId == congViec.Id && x.IsDeleted == false).ToList();
                return congViecCon;
            }
            return null;
        }
    }
}