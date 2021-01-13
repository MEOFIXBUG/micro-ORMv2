using _4_ORM.Community;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ORM.Core
{
    class Test : DbContext
    {
        public Test(string _name) : base(_name)
        {

        }
    }
}
