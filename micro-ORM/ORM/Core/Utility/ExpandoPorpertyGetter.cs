using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM.Core.Utility
{
    public class ExpandoPorpertyGetter : IPropertyGetter
    {
        public IDictionary<string, object> GetPropertyDic(object Fo)
        {
            var eoDic = Fo as IDictionary<string, object>;
            Debug.Assert(eoDic != null);
            return eoDic;
        }
    }
}
