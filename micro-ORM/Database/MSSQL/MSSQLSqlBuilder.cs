using micro_ORM.ORM.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.Database.MSSQL
{
    public class MSSQLSqlBuilder : BaseSqlBuilder
    {
        public override ISqlBuilder CreateOne()
        {
            return new MSSQLSqlBuilder();
        }
    }
}
