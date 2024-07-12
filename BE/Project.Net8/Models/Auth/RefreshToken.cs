using DTC.DefaultRepository.Models.Base;
using DTC.T;
namespace Project.Net8.Models.Auth
{
    public class RefreshTokenModel : Audit, TEntity<string>
    {
        public string AccessToken { get; set; }
        
        public string RefreshToken { get; set; }

        public string JwtId { get; set; }

        public DateTime CreationDateToken { get; set; }

        public DateTime ExpiryDateToken { get; set; }

        public double ExpiryDateRefreshToken { get; set; }
        
        public bool Invalidated { get; set; }
        
        
        public string UserId { get; set; }
        
        public string UnitRoleId { get; set; }
    }
    
    
    public class TokenApiModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }

        public TokenApiModel(string accessToken, string refreshToken)
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
        }
    }
    
    
    
    public class RefreshTokenResultModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
        
        public DateTime  ExpiryDate { get; set; }

        public RefreshTokenResultModel(string accessToken, string refreshToken , DateTime  expiryDate )
        {
            this.AccessToken = accessToken;
            this.RefreshToken = refreshToken;
            this.ExpiryDate = expiryDate;
        }
    }
    
    
    
    
}