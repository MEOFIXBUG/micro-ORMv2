using micro_ORM.ORM.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.Database.MSSQL
{
    class MicroORMMsSqlDb: MicroORMBaseDb
    {
        public MicroORMMsSqlDb(string connectionString)
        {
            this.DbConnection = new SqlConnection(connectionString);
            this.SqlBuilder = new MSSQLSqlBuilder();
        }
    }
}
