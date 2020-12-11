using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM.Core.Exceptions
{
    public class ParaErrorException : MicroORMException
    {
        public ParaErrorException(string message, Object para) : base("PE", message)
        {

        }

        public ParaErrorException(string message) : base("PE", message)
        {

        }
    }
}
