using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using DTC.DefaultRepository.Constants;
using DTC.DefaultRepository.Exceptions;
using DTC.DefaultRepository.Helpers;
using DTC.MongoDB;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using Project.Net8.Constants;
using Project.Net8.Installers;
using Project.Net8.Interface.Auth;
using Project.Net8.Models.Auth;
using Project.Net8.Models.Permission;
using Project.Net8.Models.Settings;
using Project.Net8.Service.Base;

namespace Project.Net8.Service.Auth
{
    public class RefreshTokenService : BaseService, IRefreshTokenService
    {
        private DataContext _context;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly TokenValidationParameters _tokenValidationParameters;
        private readonly JwtSettings _jwtSettings;
        private BaseMongoDb<RefreshTokenModel, string> BaseMongoDb;
        private HttpContext _httpContext { get { return _contextAccessor.HttpContext; } }
        public RefreshTokenService(
            DataContext context,
            TokenValidationParameters tokenValidationParameters,
            JwtSettings jwtSettings,
            IHttpContextAccessor contextAccessor) :
            base(context, contextAccessor)
        {
            _context = context;
            _jwtSettings = jwtSettings;
            _tokenValidationParameters = tokenValidationParameters;
            BaseMongoDb = new BaseMongoDb<RefreshTokenModel, string>(_context.REFRESHTOKEN);
        }

        public async Task<RefreshTokenModel> Create(RefreshTokenModel model)
        {
            if (model == default)
            {
                throw new ResponseMessageException().WithException(DefaultCode.EXCEPTION);
            }
            var result = await BaseMongoDb.CreateAsync(model);
                if (result.Entity.Id == default || !result.Success)
                {
                    throw new ResponseMessageException().WithException(DefaultCode.CREATE_FAILURE);
                }
                return model;
        }



        public async Task<SecurityToken> CreateJwtSecurityToken(JwtSecurityTokenHandler tokenHandler , User user)
        {
            
            var key = Encoding.ASCII.GetBytes(_jwtSettings.Secret);
            
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ListActionDefault.KeyId, user.Id),
                new Claim(ListActionDefault.UnitRoleId, user.UnitRole != null ? user.UnitRole.Id : "KHONGCO"),
            };
            
            /*new Claim("UserName", userName),
            new Claim("Id", id),*/
            
            
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.Add(_jwtSettings.TokenLifetime),
                SigningCredentials =
                    new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return token; 
        }


        public async Task<dynamic> RefreshToken(TokenApiModel model)
        {
            if (model == default)
                throw new ResponseMessageException().WithException(DefaultCode.EXCEPTION);
            
            var resultRefreshToken = ValidateJwtToken(model.AccessToken);
            
            if (resultRefreshToken == null || resultRefreshToken.Username == null || resultRefreshToken.UserId == null)
                throw new ResponseMessageException().WithException(DefaultCode.TOKEN_NOT_FOUND);


            var refreshToken = _context.REFRESHTOKEN.Find(x => !x.IsDeleted
                                                               && !x.Invalidated &&
                                                               x.RefreshToken == model.RefreshToken &&
                                                               x.AccessToken == model.AccessToken && 
                                                               x.UserId == resultRefreshToken.UserId).FirstOrDefault();
            
            if (refreshToken == null)
                throw new ResponseMessageException().WithException(DefaultCode.TOKEN_OR_REFRESH_TOKEN_NOT_FOUND);

            var today = FormatTime.ConvertToUnixTimestamp(DateTime.UtcNow);

            if (refreshToken.ExpiryDateRefreshToken - today < 0)
            {
                throw new ResponseMessageException().WithException(DefaultCode.REFRESH_TOKEN_OUT_TIME);
            }


            var user = await  _context.USERS.Find(x => !x.IsDeleted && x.Id == refreshToken.UserId).FirstOrDefaultAsync();
            
            if (user == null)
                throw new ResponseMessageException().WithException(DefaultCode.EXCEPTION);
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = await CreateJwtSecurityToken(tokenHandler, user);

            if (token == null || token.Equals(""))
                throw new ResponseMessageException().WithException(DefaultCode.EXCEPTION);

            
            var refreshTokenModel = new RefreshTokenModel
            {
                JwtId = token.Id,
                UserId = resultRefreshToken.UserId,
                AccessToken = tokenHandler.WriteToken(token),
                CreationDateToken = DateTime.UtcNow,
                ExpiryDateToken = DateTime.UtcNow.Add(_jwtSettings.TokenLifetime),
                ExpiryDateRefreshToken = FormatTime.ConvertToUnixTimestamp(DateTime.UtcNow.Add(_jwtSettings.TokenRefreshStore)),
                RefreshToken =  GenerateRefreshToken()
            };

            if (refreshTokenModel.AccessToken == null || refreshTokenModel.RefreshToken == null)
                throw new ResponseMessageException().WithException(DefaultCode.EXCEPTION);
            var createdRefreshToken = Create(refreshTokenModel);
            
            return new RefreshTokenResultModel(refreshTokenModel.AccessToken , refreshTokenModel.RefreshToken , refreshToken.ExpiryDateToken );

        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
        
        public ResultRefreshToken? ValidateJwtToken(string token)
        {
            if (token == null || token.Equals(""))
                return null;
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jsonToken = handler.ReadToken(token);
                var tokenS = jsonToken as JwtSecurityToken;
                var result = new ResultRefreshToken()
                {
                    Username = tokenS.Claims.First(claim => claim.Type == ListActionDefault.KeyId).Value,
                    UserId = tokenS.Claims.First(claim => claim.Type == ListActionDefault.KeyId).Value,
                    UnitRoleId = tokenS.Claims.First(claim => claim.Type == ListActionDefault.UnitRoleId).Value,
                    
                };
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}