using _4_ORM.Community;
using _4_ORM.Enum;
using _4_ORM.Static;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _4_ORM.Core
{
    public class DbSet<TEntity> where TEntity : class
    {
        string table = typeof(TEntity).Name;
        private DBManager _dbManager;
        string currentCommand = "";
        public DbSet(DBManager dBManager)
        {
            _dbManager = dBManager;
            currentCommand = SqlQuery.selectSQL(table);
        }
        public IEnumerable<TEntity> Join<JT>(Tuple<string, string> frontToEnd)
        {
            string joinedTable = typeof(JT).Name;
            var joinedCommand = string.Format(SqlQuery.selectSQL(joinedTable), "");
            var data1= _dbManager.Query<JT>(joinedCommand, CommandType.Text);
            var tableCommand= string.Format(SqlQuery.selectSQL(table), "");
            var data2=_dbManager.Query<TEntity>(joinedCommand, CommandType.Text);
            //currentCommand += $"JOIN {joinedTable} j  ON t.{frontToEnd.Item1}= j.{frontToEnd.Item2} ";
            return null;
        }
        public DbSet<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            var condition = Helpers.GetWhereClause<TEntity>(expression);
            currentCommand += $"WHERE t.{condition} ";
            return this;
        }
        public void GroupBy()
        {

        }
        public void Having()
        {

        }
        public DbSet<TEntity> OrderBy(string field, Order order=Order.ASC)
        {
            currentCommand += $" ORDER BY t.{field}  {order.ToString()} ";
            return this;
        }
        public DbSet<TEntity> Top(int number)
        {
            currentCommand = string.Format(currentCommand, $" TOP {number} ");
            return this;
        }
        public IEnumerable<TEntity> Excute()
        {
            var clone = string.Format(currentCommand,"");
            currentCommand = SqlQuery.selectSQL(table);
            return _dbManager.Query<TEntity>(clone, CommandType.Text);
           
        }
        public long Insert(object item)
        {
            long insertedId;
            var sqlCommand = SqlQuery.insertSQL(table, item.ToDictionary());
            sqlCommand += "; SELECT LAST_INSERT_ID();";
            _dbManager.Insert(sqlCommand, CommandType.Text, out insertedId);
            return insertedId;
        }
        public bool Update(Expression<Func<TEntity, bool>> expression, object item)
        {
            var condition = Helpers.GetWhereClause<TEntity>(expression);
            var sqlCommand = SqlQuery.updateSQL(table, item.ToDictionary(), condition);
            return _dbManager.Update(sqlCommand, CommandType.Text);
        }
        //public long Update(TEntity item)
        //{
        //    return 0;
        //}
        public bool Delete(Expression<Func<TEntity, bool>> expression)
        {
            var condition = Helpers.GetWhereClause<TEntity>(expression);
            var sqlCommand = SqlQuery.deleteSQL(table,condition );
            return _dbManager.Delete(sqlCommand, CommandType.Text);
        }
        //public bool Delete(TEntity item)
        //{
        //    var sqlCommand = SqlQuery.deleteSQL(table, item.ToDictionary());
        //    return true;
        //}
    }
}
