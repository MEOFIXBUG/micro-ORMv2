using micro_ORM.ORM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.Database.MYSQL
{
    public class MySqlSqlBuilder : BaseSqlBuilder
    {
        public MySqlSqlBuilder()
        {
            SqlGen = new MySqlSqlGenerator();
        }

        public override ISqlBuilder CreateOne()
        {
            return new MySqlSqlBuilder();
        }
    }
}
