using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TableNameAttribute : BaseAttribute
    {
        public TableNameAttribute(string tableName)
        {
            TableName = tableName;
        }
        public string TableName { get; set; }
    }
}
