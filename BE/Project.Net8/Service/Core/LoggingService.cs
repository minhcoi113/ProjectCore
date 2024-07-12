using DTC.MongoDB;
using MongoDB.Bson;
using Project.Net8.Installers;
using Project.Net8.Interface.Core;
using Project.Net8.Models.Core;
using Project.Net8.Service.Base;

namespace Project.Net8.Service.Core
{
        public class LoggingService : BaseService, ILoggingService
        {
            private DataContext _context;
            private BaseMongoDb<LoggingModel, string> BaseMongoDb;
            public LoggingModel _logging = new LoggingModel(); 
            public LoggingService(
                DataContext context,
                IHttpContextAccessor contextAccessor) :
                base(context, contextAccessor)
            {
                _context = context;
                BaseMongoDb = new BaseMongoDb<LoggingModel, string>(_context.LOGGING);
            }
            
            public async Task<bool> SaveChanges()
            {
                if (CurrentUser != default)
                {
                    _logging.CreatedAt = DateTime.Now;
                    _logging.CreatedBy = CurrentUserName != null ? CurrentUserName : "Không Xác Định";
                }
            
                _logging.Id =  BsonObjectId.GenerateNewId().ToString();  
                var result = await BaseMongoDb.CreateAsync(_logging);
                return result.Success;
            }

            public LoggingService WithDonVi(string? donVi)
            {
                _logging.DonVi = donVi != null ? donVi.Trim() : null;
                return this;
            }
            public LoggingService WithContent(string? content)
            {
                _logging.Content = content  != null ? content.Trim() : null;;
                return this;
            }
            public LoggingService WithStatus(int? status)
            {
                _logging.Status = status;
                return this;
            }

            public LoggingService WithAPI(string api)
            {
                _logging.API = api  != null ? api.Trim() : null;;;
                return this;
            }
        }
    
}