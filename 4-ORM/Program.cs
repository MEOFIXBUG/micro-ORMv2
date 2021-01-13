using _4_ORM.Core;
using _4_ORM.Enum;
using micro_ORM.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ORM
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Test("MySqlConnectionString");
            var b = a.Set<Staff>();
            var item = new Staff();
            item.Email = "Sangdoan956@gmail.com";
            item.Account_id = 1;
            item.IdentityCard = "215483062";
            item.Phone = "0589005648";
            item.Name = "123aaaa";
            item.Address = "bbb23123bbb";
            Console.WriteLine(b.Insert(item));
            var item1 = new { Email="Doansang789@gmail.com" };
            var y = b.Update(x => x.ID == 1000, item);
            var z = b.Delete(x => x.ID == 1014);
            var g8 = b.OrderBy("ID", Order.DESC).Excute();
            var g= b.Where(x => x.Account_id == 1).OrderBy("ID",Order.DESC).Excute();
            Console.ReadKey();
           
        }
    }
}
