using micro_ORM.ORM;
using micro_ORM.ORM.Core;
using micro_ORM.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionStr = "server=127.0.0.1;port=3306;user id=root; password=toor; database=hotel";
            IMicroORMDb db = Manager.GetDb(connectionStr, SupportedDb.MYSQL);
            var a=db.Query<Account>();
        }
    }
}
