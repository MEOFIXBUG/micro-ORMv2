using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ColumnNameAttribute : BaseAttribute
    {
        public ColumnNameAttribute(string columnName)
        {
            ColumnName = columnName;
        }
        public string ColumnName { get; set; }
    }
}
