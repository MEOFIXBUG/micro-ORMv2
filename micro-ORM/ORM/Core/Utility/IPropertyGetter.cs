using System.Collections.Generic;

namespace micro_ORM.ORM.Core.Utility
{
    public interface IPropertyGetter
    {
        IDictionary<string, object> GetPropertyDic(object Fo);
    }
}