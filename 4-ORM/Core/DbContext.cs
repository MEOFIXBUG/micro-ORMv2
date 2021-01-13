using _4_ORM.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ORM.Core
{
    public abstract class DbContext
    {
        protected DBManager dBManager;
        protected string name;
        public  DbContext(string _name)
        {
            name = _name;
            dBManager = new DBManager(_name);
        }
        public DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return new DbSet<TEntity>(dBManager);
        }
    }
}
