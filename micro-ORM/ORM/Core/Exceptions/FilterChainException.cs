using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM.Core.Exceptions
{
    public class FilterChainException : MicroORMException
    {
        public FilterChainException(string message) : base("FCE", message)
        {
        }
    }
}
