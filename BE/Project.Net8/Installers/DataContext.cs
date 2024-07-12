using System.Reflection;
using MongoDB.Driver;
using Project.Net8.Constants;
using Project.Net8.Constants;
using Project.Net8.Models.Auth;
using Project.Net8.Models.Core;
using Project.Net8.Models.Major;
using Project.Net8.Models.Permission;

namespace Project.Net8.Installers
{
    public class DataContext
    {
      

        #region Auth 
        private readonly IMongoCollection<RefreshTokenModel> _refreshToken;
        private readonly IMongoCollection<User> _users;
        #endregion

        #region Common 

        private readonly IMongoCollection<CommonModel> _common;

        #endregion
        
        #region Core
        private readonly IMongoClient _mongoClient = null;
        private readonly IMongoDatabase _context = null;
        private readonly IMongoCollection<Module> _module;
        private readonly IMongoCollection<Menu> _menu;
        
        private readonly IMongoCollection<APIModel> _api;
            
        private readonly IMongoCollection<DonVi> _donVi;
        
        
     
        private readonly IMongoCollection<UnitRole> _unitRole;
        
        private readonly IMongoCollection<FileModel> _file;
        

        private readonly Dictionary<string,  IMongoCollection<CommonModel>> _listCommonCollection;

        private readonly IMongoCollection<LoggingModel> _logging;

        #endregion
        
        #region Nghiep vu    
        
        private readonly IMongoCollection<BaiThiModel> _baiThi;
    

        #endregion



        public DataContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.
               GetValue<string>(ConfigurationDb.MONGO_CONNECTION_STRING));
            if (client != null)
            {
                #region Core
                
                _context = client.GetDatabase(configuration.GetValue<string>(ConfigurationDb.MONGO_DATABASE_NAME));
                _users = _context.GetCollection<User>(DefaultNameCollection.USERS);
                _refreshToken = _context.GetCollection<RefreshTokenModel>(DefaultNameCollection.REFRESHTOKEN);                
                _menu = _context.GetCollection<Menu>(DefaultNameCollection.MENU);
                _api = _context.GetCollection<APIModel>(DefaultNameCollection.API);
                _unitRole =_context.GetCollection<UnitRole>(DefaultNameCollection.UNIT_ROLE);
                _file = _context.GetCollection<FileModel>(DefaultNameCollection.FILES);
                _logging = _context.GetCollection<LoggingModel>(DefaultNameCollection.LOGGING);
                _listCommonCollection = new Dictionary<string,  IMongoCollection<CommonModel>>();
                foreach ( ItemCommon item in ListCommon.listCommon)
                {
                    IMongoCollection<CommonModel> colection = Database.GetCollection<CommonModel>(item.Code);
                    _listCommonCollection.Add(item.Code, colection);
                }

                #endregion

                
                
                #region NghiepVu
                
                
                _baiThi = _context.GetCollection<BaiThiModel>(DefaultNameCollection.BAITHI);
                
                

                #endregion

            }
        }


        #region Core

              
        public IMongoDatabase Database
        {
            get { return _context; }
        }
        public IMongoClient Client
        {
            get { return _mongoClient; }
        }

        public IMongoCollection<RefreshTokenModel> REFRESHTOKEN { get => _refreshToken; }

        public IMongoCollection<UnitRole> UNIT_ROLE { get => _unitRole; }

        public IMongoCollection<User> USERS { get => _users; }
        
        public IMongoCollection<DonVi> DONVI { get => _donVi; }

        public IMongoCollection<Menu> MENU { get => _menu; }
        
        public IMongoCollection<APIModel> API { get => _api; }

        
        public IMongoCollection<FileModel> FILES { get => _file; }
        
        public IMongoCollection<LoggingModel> LOGGING { get => _logging; }
        
        private Dictionary<string,  IMongoCollection<CommonModel>> CommonCollection { get => _listCommonCollection; }
        public  IMongoCollection<CommonModel> GetCategoryCollectionAs(string collectionName)
        {
            return  CommonCollection[collectionName];
        }

        #endregion

        #region NghiepVu
        
        public IMongoCollection<BaiThiModel> BAITHI { get => _baiThi; }
        
        #endregion



    }


}