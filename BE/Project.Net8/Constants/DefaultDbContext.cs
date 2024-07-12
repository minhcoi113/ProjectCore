namespace Project.Net8.Constants
{
    public static class DefaultNameCollection
    {
        public const string USERS = "CR_USERS";
        public const string REFRESHTOKEN = "CR_REFRESHTOKEN";
        public const string LOGGING = "CR_LOGGING";
        public const string MENU = "CR_MENU";
        public const string API = "CR_API";
        public const string UNIT_ROLE = "CR_UNIT_ROLE";
        public const string FILES = "CR_FILES";
        public const string BAITHI = "NV_BAITHI";

    }

    public static class ConfigurationDb
    {
        #region MONGODB 
        public const string MONGO_CONNECTION_STRING = "DbSettings:ConnectionString";
        public const string MONGO_DATABASE_NAME = "DbSettings:DatabaseName";
        #endregion

        #region POSTGRE
        public const string POSTGRE_CONNECTION = "DbSettings:PostgreConnection";
        #endregion                                                                                                      
    }
}