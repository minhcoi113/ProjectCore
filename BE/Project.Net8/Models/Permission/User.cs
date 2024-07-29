using DTC.DefaultRepository.Models.Base;
using DTC.DefaultRepository.Models.Core;
using DTC.T;
using MongoDB.Bson.Serialization.Attributes;
using Project.Net8.Models.Core;
using Project.Net8.ViewModels;

namespace Project.Net8.Models.Permission
{
     public class User : Audit, TEntity<string>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        
        public FileShortModel Avatar { get; set; }

        public CoreModel DonVi { get; set; }

        public CoreModel UnitRole { get; set; }

        public bool IsAppAuthentication { get; set; } = false;
        public bool IsVerified { get; set; }
        public bool IsActived { get; set; } = true;
        public bool IsSyncPasswordSuccess { get; set; } = true;
        [BsonIgnore]   public bool IsRequireChangePassword { get; set; } = false;
        
        
        [BsonIgnore] public string Password { get; set; }
        
        [BsonIgnore] public string OldPassword { get; set; }
        

        [BsonIgnore] public List<string> Permissions { get; set; }
        
        [BsonIgnore] public List<NavMenuVM> Menu { get; set; }

        
        [BsonIgnore] public string Token { get; set; }
        


    }
}