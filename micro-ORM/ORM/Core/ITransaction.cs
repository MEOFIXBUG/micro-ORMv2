using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM.Core
{
    public interface ITransaction
    {
        void Commit();
        void Rollback();
        void Dispose();
    }
}
