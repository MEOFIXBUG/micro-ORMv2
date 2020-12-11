using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM.Core.BasicDefinitions
{
    public class FilterObject : IFilterObject
    {
        public Type ClassType { get; set; }
        public FilterType Filter { get; set; }
        public dynamic Cons { get; set; }
    }
}
