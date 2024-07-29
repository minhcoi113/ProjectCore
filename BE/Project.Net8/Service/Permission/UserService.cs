using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using DTC.DefaultRepository.Models.Core;
using DTC.MongoDB;
using MongoDB.Driver;
using Project.Net8.Constants;
using Project.Net8.Extensions;
using Project.Net8.Installers;
using Project.Net8.Interface.Permission;
using Project.Net8.Models.Permission;
using Project.Net8.Service.Base;
using Project.Net8.ViewModels;
using SharpCompress.Compressors.Xz;
using System.Xml.Linq;

namespace Project.Net8.Service.Permission
{
    public class UserService : BaseService, IUserService
    {
        private DataContext _context;
        private BaseMongoDb<User, string> BaseMongoDb;
        IMongoCollection<User> _collection;

        public UserService(
            DataContext context,
            IHttpContextAccessor contextAccessor) :
            base(context, contextAccessor)
        {
            _context = context;
            BaseMongoDb = new BaseMongoDb<User, string>(_context.USERS);
            _collection = context.USERS;
        }


        public async Task<dynamic> Create(User model)
        {
             if (model == default ||  model.UserName == null)
                 throw new ResponseMessageException().WithException(DefaultCode.ERROR_STRUCTURE);
             
            if (FormatterString.HasDiacritics(model.UserName))
            {
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                    .WithMessage("UserName không được có dấu.");
            }
            // if (CurrentUser == null)
            //     throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
            //         .WithMessage("Lỗi vui lòng đăng nhập lại để lấy dữ liệu.");
            var checkName = _context.USERS.Find(x => !x.IsDeleted && x.UserName == model.UserName )
                .FirstOrDefault();
            if (checkName != default)
            {
                throw new ResponseMessageException().WithCode(DefaultCode.DATA_EXISTED)
                    .WithMessage($"Tên tài khoản {checkName.UserName} đã tồn tại.");
            }
            var unitRole = await  _context.UNIT_ROLE.Find(x => !x.IsDeleted && x.Id == model.UnitRole.Id)
                .FirstOrDefaultAsync();
            if (unitRole == null)
            {
                throw new ResponseMessageException().WithCode(DefaultCode.DATA_NOT_FOUND)
                    .WithMessage("Nhóm quyền không tồn tại trong hệ thống");
            }
            var role = _context.UNIT_ROLE.Find(x => !x.IsDeleted).FirstOrDefault();
            var rolemodel = new CoreModel()
            {
                Id = role.Id,
                Name = role.Name
            };
            var entity = new User
            {
                UserName = model.UserName,
                Email = model.Email,
                Name = model.Name,
                UnitRole = model.UnitRole,
                CreatedAt = DateTime.Now,
                CreatedBy = CurrentUserName,
                IsVerified = model.IsVerified,
                IsSyncPasswordSuccess = model.IsSyncPasswordSuccess,
                IsActived = model.IsActived,
            };
            
            byte[] passwordHash, passwordSalt;
            if (string.IsNullOrEmpty(model.Password))
            {
                model.Password = DefaultPassword.Password;
            }
            PasswordExtensions.CreatePasswordHash(model.Password, out passwordHash, out passwordSalt);
            entity.PasswordHash = passwordHash;
            entity.PasswordSalt = passwordSalt;
            var result = await BaseMongoDb.CreateAsync(entity);

            if (result.Entity.Id == default || !result.Success)
            {
                return null;
            }

            
            return entity;
        }

        public async Task<dynamic> Update(User model)
        {
            if (model == default)
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(DefaultMessage.DATA_NOT_EMPTY);

            if (model.Password != null)
            {
                if (FormatterString.HasDiacritics(model.Password))
                {
                    throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                        .WithMessage("Passworld không được có dấu hoặc khoảng cách.");
                }
            }
            
            var entity = _context.USERS.Find(x => x.Id == model.Id).FirstOrDefault();

            if (entity == default)
                throw new ResponseMessageException().WithException(DefaultCode.EXCEPTION);

            
           // entity.UnitRole = model.UnitRole;
            entity.Email = model.Email;
            entity.Name = model.Name;
            entity.Avatar = model.Avatar;


            entity.ModifiedAt = DateTime.Now;
            entity.ModifiedBy = CurrentUserName;
            entity.IsVerified = model.IsVerified;
            entity.IsSyncPasswordSuccess = model.IsSyncPasswordSuccess;
            entity.IsActived = model.IsActived;
            
            if ((string.IsNullOrEmpty(model.Password) && !string.IsNullOrEmpty(model.OldPassword)) ||
                (!string.IsNullOrEmpty(model.Password) && string.IsNullOrEmpty(model.OldPassword)))
            {
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                    .WithMessage("MẬT KHẨU CŨ VÀ MẬT KHẨU MỚI KHÔNG ĐƯỢC BỎ TRỐNG");
            }
            if(!string.IsNullOrEmpty(model.Password) && !string.IsNullOrEmpty(model.OldPassword))
            {
                
                if ( !PasswordExtensions.VerifyPasswordHash(model.OldPassword, entity.PasswordHash, entity.PasswordSalt))
                {
                    throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                        .WithMessage("MẬT KHẨU CŨ SAI. VUI LÒNG KIỂM TRA LẠI MẬT KHẨU !");
                }
                if (model.Password.Equals(DefaultPassword.Password))
                    {
                        throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                            .WithMessage("KHÔNG ĐƯỢC ĐỔI MẬT KHẨU MẶC ĐỊNH DefaultPassword.Password");
                }
                    byte[] passwordHash, passwordSalt;
                    PasswordExtensions.CreatePasswordHash(model.Password, out passwordHash, out passwordSalt);
                    entity.PasswordHash = passwordHash;
                    entity.PasswordSalt = passwordSalt;
            }
            var result = await BaseMongoDb.UpdateAsync(entity);
            if (!result.Success)
            {

                throw new ResponseMessageException().WithException(DefaultCode.UPDATE_FAILURE);
            }
           
            return entity;
        }

        public async Task<dynamic> ChangePassword(UserVM model)
        {
            if (model == default)
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                     .WithMessage(DefaultMessage.DATA_NOT_EMPTY);

            var entity = _context.USERS.Find(x => x.UserName == model.UserName).FirstOrDefault();
            if (entity == default)
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                    .WithMessage(DefaultMessage.DATA_NOT_FOUND);

            if (!string.IsNullOrEmpty(model.Password))
            {
                byte[] passHash, passSalt;
                passHash = entity.PasswordHash;
                passSalt = entity.PasswordSalt;
                var pass = PasswordExtensions.VerifyPasswordHash(model.Password, passHash, passSalt);
                if (pass != true)
                {
                    throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                        .WithMessage("Mật khẩu không chính xác");
                }
                else
                {
                    if (model.newPass == model.confirmPass)
                    {
                        byte[] passwordHash, passwordSalt;
                        PasswordExtensions.CreatePasswordHash(model.newPass, out passwordHash, out passwordSalt);
                        entity.PasswordHash = passwordHash;
                        entity.PasswordSalt = passwordSalt;
                    }
                }
            }

            var result = await BaseMongoDb.UpdateAsync(entity);
            if (!result.Success)
            {
                throw new ResponseMessageException().WithCode(DefaultCode.EXCEPTION)
                    .WithMessage("Đổi mật khẩu thất bại.");
            }
            return entity;
        }

    }
}
