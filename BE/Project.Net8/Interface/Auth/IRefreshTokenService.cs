using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Project.Net8.Models.Auth;
using Project.Net8.Models.Permission;

namespace Project.Net8.Interface.Auth
{
    public interface IRefreshTokenService
    {
        Task<RefreshTokenModel> Create(RefreshTokenModel model);
        
        
        
        
        Task<SecurityToken> CreateJwtSecurityToken(JwtSecurityTokenHandler tokenHandler  , User user);
        
        
        Task<dynamic> RefreshToken(TokenApiModel model);


        public  string GenerateRefreshToken();


        public ResultRefreshToken? ValidateJwtToken(string token); 


    }
}