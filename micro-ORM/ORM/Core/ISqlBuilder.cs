using micro_ORM.ORM.Core.BasicDefinitions;
using micro_ORM.ORM.Core.Dapper;
using System;

namespace micro_ORM.ORM.Core
{
    public interface ISqlBuilder
    {
        string SQLString { get; set; }
        string GetWhereSQLString();
        string GenCreateTableSql<T>();
        string GenDropTableSql<T>();
        string GenInsertSql<T>();

        string GenSelect(Type t);
        string GenDelete(Type t);
        string GenUpdate(Type t, Object obj);
        string GenWhereCons(IFilterObject fo);
        DynamicParameters GetWhereParas();

        ISqlBuilder CreateOne();
    }
}
