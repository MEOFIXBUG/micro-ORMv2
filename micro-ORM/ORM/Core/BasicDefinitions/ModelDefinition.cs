using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_ORM.ORM.Core.BasicDefinitions
{
    public class ModelDefinition
    {
        public string TableName { get { return _tableName; } }
        public Dictionary<string, ColumnFieldDefinition> PropertyColumnDic { get; private set; }
        private readonly string _tableName;
        public ModelDefinition(string tablename, Dictionary<string, ColumnFieldDefinition> propertycolumnDic)
        {
            _tableName = tablename;
            PropertyColumnDic = propertycolumnDic;
        }

    }
}
