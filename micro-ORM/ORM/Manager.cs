using micro_ORM.ORM.Core;

namespace micro_ORM.ORM
{
    public static class Manager
    {
        public static IMicroORMDb GetDb(string connectionString, SupportedDb dbType)
        {
            return MicroORMFactory.Instance.GetDb(connectionString, dbType);
        }
    }
}
