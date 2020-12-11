using micro_ORM.Database.MSSQL;
using micro_ORM.Database.MYSQL;
using micro_ORM.ORM.Core;
using micro_ORM.ORM.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM
{
    class MicroORMFactory
    {
        private static MicroORMFactory instance;
        private MicroORMFactory() { }
        public static MicroORMFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MicroORMFactory();
                }
                return instance;
            }
        }
        public IMicroORMDb GetDb(string ConnectString, SupportedDb dbType)
        {
            switch (dbType)
            {
                case SupportedDb.MSSQL:
                    return new MicroORMMsSqlDb(ConnectString);
                case SupportedDb.POSTGRESQL:
                    return null;
                    //return new MicroORMPostgreSqlDb(ConnectString);
                case SupportedDb.MYSQL:
                    //return null;
                    return new MicroORMMySqlDb(ConnectString);
                default:
                    throw new MicroORMException("N", "Not SupportDB");
            }
        }
    }
}
