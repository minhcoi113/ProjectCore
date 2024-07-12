using System.IdentityModel.Tokens.Jwt;
using System.Security.Principal;
using System.Text;
using DTC.DefaultRepository.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.IdentityModel.Tokens;
using MongoDB.Driver;
using Project.Net8.Constants;
using Project.Net8.Models.Permission;

namespace Project.Net8.Authorization
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
    public class AuthorizeAttribute : Attribute, IAuthorizationFilter
    {
        
        private readonly IMongoDatabase _context = null;
        private readonly IMongoCollection<UnitRole> _unitRole;
       
        public AuthorizeAttribute()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration _configuration = builder.Build();
            
            var mongodbName =  _configuration.GetSection(ConfigurationDb.MONGO_DATABASE_NAME).Value;
            
            var connection =  _configuration.GetSection(ConfigurationDb.MONGO_CONNECTION_STRING).Value;
            
            var client = new MongoClient(connection);

            _context = client.GetDatabase(mongodbName);
            
            _unitRole = _context.GetCollection<UnitRole>(DefaultNameCollection.UNIT_ROLE);
            
        }
        
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
            if (allowAnonymous)
                return;
            
            if (!ValidateToken(context.HttpContext.Request.Headers["Authorization"]))
            {
                context.Result = new JsonResult(
                    new ResultMessageResponse()
                        .WithCode(DefaultCode.BEYOND_TIME)
                        .WithMessage("Hết thời gian truy cập vui lòng đăng nhập lại để xử lý tiếp!")
                );
            }

            var unitRole = context.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ListActionDefault.UnitRoleId)?.Value;

            if (unitRole == null)
                context.Result = new JsonResult(
                    new ResultMessageResponse()
                        .WithCode(DefaultCode.BEYOND_TIME)
                        .WithMessage("Hết thời gian truy cập vui lòng đăng nhập lại để xử lý tiếp!")
                );
            
            UnitRole data = _unitRole.Find(x => !x.IsDeleted && x.Id == unitRole).FirstOrDefault();

         
            if (data != null && data.Controller.Count > 0)
            {   
                var listAction = context.ActionDescriptor.AttributeRouteInfo.Template.Replace("api/v1/","");

                var action = listAction.Split("/");

              if (action != null && action[0] != null && action[1] != null)
              {
                  var role = data.Controller.Find(x => x.key == action[0] && x.ListAction.Any(x=> x == action[1])); 
                  
                  if (role == null)
                      context.Result = new JsonResult(
                          new ResultMessageResponse()
                              .WithCode(DefaultCode.NOT_HAVE_ACCESS)
                              .WithMessage(DefaultMessage.NOT_HAVE_ACCESS)
                      );
              }
              
            }
            else
            {
                context.Result = new JsonResult(
                    new ResultMessageResponse()
                        .WithCode(DefaultCode.NOT_HAVE_ACCESS)
                        .WithMessage(DefaultMessage.NOT_HAVE_ACCESS)
                );
            }
           
        }

        private static bool ValidateToken(string authToken)
        {
            try
            {

                if (authToken == null || authToken == default)
                    return false;
                authToken = authToken.Replace("Bearer ", "");
                var tokenHandler = new JwtSecurityTokenHandler();
                var validationParameters = GetValidationParameters();
                SecurityToken validatedToken;
                IPrincipal principal = tokenHandler.ValidateToken(authToken, validationParameters, out validatedToken);
                var currentDate = DateTime.Now.ToLocalTime();
                var validatedLocal = validatedToken.ValidTo.ToLocalTime();
                if (validatedLocal < currentDate)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {

            }

            return false;
        }

        private static TokenValidationParameters GetValidationParameters()
        {
            return new TokenValidationParameters()
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("my@longshen#secretkey&05092019")),
                ValidateIssuer = false,
                ValidateAudience = false,
                RequireExpirationTime = false,
                ValidateLifetime = false,
                ClockSkew = TimeSpan.Zero
            };
        }
    }
}

