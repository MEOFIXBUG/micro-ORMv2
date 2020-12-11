using micro_ORM.ORM.Core;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.Database.MYSQL
{
    public class MicroORMMySqlDb : MicroORMBaseDb
    {
        public MicroORMMySqlDb(string dbConnectionString)
        {
            DbConnection = new MySqlConnection(dbConnectionString);
            SqlBuilder = new MySqlSqlBuilder();
        }
    }
}
