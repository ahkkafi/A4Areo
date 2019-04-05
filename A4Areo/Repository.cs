using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace A4Areo
{
    public class Repository<T>
    {
        private string ConnStr { get; set; }
        private string _tableName { get; set; }
        private string primaryKey { get; set; }

        private SqlConnection Conn { get; set; }

        public Repository()
        {
            ConnStr = @"Data Source=.\SQLEXPRESS;Initial Catalog=AgentDb;Integrated Security=True";

            Conn = new SqlConnection(ConnStr);
            _tableName = typeof(T).Name;

            primaryKey = _tableName + "Id";


        }

        public void Insert(T obj)
        {
            var propertyContainer = ParseProperties(obj);
            var sql = string.Format("INSERT INTO [{0}] ({1})  VALUES(@{2}) SELECT CAST(scope_identity() AS int)",
                typeof(T).Name,
                string.Join(", ", propertyContainer.ValueNames),
                string.Join(", @", propertyContainer.ValueNames));

            using (Conn)
            {
                var id = Conn.Query<int>
                (sql, propertyContainer.ValuePairs, commandType: CommandType.Text).First();
                SetId(obj, id, propertyContainer.IdPairs);
            }
        }


        public void Update(T obj)
        {
            var propertyContainer = ParseProperties(obj);
            var sqlIdPairs = GetSqlPairs(propertyContainer.IdNames);
            var sqlValuePairs = GetSqlPairs(propertyContainer.ValueNames);
            var sql = string.Format("UPDATE [{0}] SET {1} WHERE {2}", typeof(T).Name, sqlValuePairs, sqlIdPairs);
            Execute(CommandType.Text, sql, propertyContainer.AllPairs);


        }



        public void Delete(T obj)
        {
            var propertyContainer = ParseProperties(obj);
            var sqlIdPairs = GetSqlPairs(propertyContainer.IdNames);
            var sql = string.Format("DELETE FROM [{0}]  WHERE {1}", typeof(T).Name, sqlIdPairs);
            Execute(CommandType.Text, sql, propertyContainer.IdPairs);
        }



        public IEnumerable<T> GetAllByConditions(string condition)
        {
            condition = condition.Replace("&&", " AND ");
            condition = condition.Replace("||", " OR ");

            using (Conn)
            {
                string sql = "SELECT * FROM [" + _tableName + "] where " + condition;
                if (string.IsNullOrEmpty(condition))
                {
                    sql = "SELECT * FROM [" + _tableName + "]";
                }

                return Conn.Query<T>(sql);
            }
        }
        public T SelectById(T obj)
        {
            var properties = ParseProperties(obj);
            primaryKey = properties.IdPairs.FirstOrDefault().Key;
            var Id = properties.IdPairs.FirstOrDefault().Value;

            using (Conn)
            {

                string sql = "SELECT * FROM " + _tableName + " Where " + primaryKey + "=" + Id;
                var result = Conn.Query<T>(sql);
                if (result.Count() == 0)
                {
                    return default(T);
                }
                else
                {
                    return result.First();
                }

            }
        }

        public IEnumerable<T> GetAll()
        {
            using (Conn)
            {
                string sql = "SELECT * FROM " + _tableName + "";
                return Conn.Query<T>(sql);
            }
        }

        protected IEnumerable<T> GetItems(CommandType commandType, string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.Query<T>(sql, parameters, commandType: commandType);
            }
        }

        protected int Execute(CommandType commandType, string sql, object parameters = null)
        {
            using (var connection = GetOpenConnection())
            {
                return connection.Execute(sql, parameters, commandType: commandType);
            }
        }

        protected SqlConnection GetOpenConnection()
        {
            var connection = new SqlConnection(ConnStr);
            connection.Open();
            return connection;
        }





        #region Reflection support

        /// <summary>
        /// Retrieves a Dictionary with name and value 
        /// for all object properties matching the given criteria.
        /// </summary>
        /// 

        private static PropertyContainer ParseProperties(T obj)
        {
            var propertyContainer = new PropertyContainer();

            var typeName = typeof(T).Name;
            var validKeyNames = new[] { "Id",
            string.Format("{0}Id", typeName), string.Format("{0}_Id", typeName) };

            var properties = typeof(T).GetProperties();
            foreach (var property in properties)
            {
                // Skip reference types (but still include string!)
                if (property.PropertyType.IsClass && property.PropertyType != typeof(string))
                    continue;

                // Skip methods without a public setter
                if (property.GetSetMethod() == null)
                    continue;

                // Skip methods specifically ignored
                if (property.IsDefined(typeof(DapperIgnore), false))
                    continue;

                var name = property.Name;
                var value = typeof(T).GetProperty(property.Name).GetValue(obj, null);

                if (property.IsDefined(typeof(DapperKey), false) || validKeyNames.Contains(name))
                {
                    propertyContainer.AddId(name, value);
                }
                else
                {
                    propertyContainer.AddValue(name, value);
                }
            }

            return propertyContainer;
        }

        /// <summary>
        /// Create a commaseparated list of value pairs on 
        /// the form: "key1=@value1, key2=@value2, ..."
        /// </summary>
        /// 

        private static string GetSqlPairs(IEnumerable<string> keys, string separator = ", ")
        {
            var pairs = keys.Select(key => string.Format("{0}=@{0}", key)).ToList();
            return string.Join(separator, pairs);
        }

        private void SetId(T obj, int id, IDictionary<string, object> propertyPairs)
        {
            if (propertyPairs.Count == 1)
            {
                var propertyName = propertyPairs.Keys.First();
                var propertyInfo = obj.GetType().GetProperty(propertyName);
                if (propertyInfo.PropertyType == typeof(int))
                {
                    propertyInfo.SetValue(obj, id, null);
                }
            }
        }

        #endregion



    }
    [AttributeUsage(AttributeTargets.Property)]
    public class DapperKey : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class DapperIgnore : Attribute
    {
    }
    public class PropertyContainer
    {
        private readonly Dictionary<string, object> _ids;
        private readonly Dictionary<string, object> _values;

        #region Properties

        internal IEnumerable<string> IdNames
        {
            get { return _ids.Keys; }
        }

        internal IEnumerable<string> ValueNames
        {
            get { return _values.Keys; }
        }

        internal IEnumerable<string> AllNames
        {
            get { return _ids.Keys.Union(_values.Keys); }
        }

        internal IDictionary<string, object> IdPairs
        {
            get { return _ids; }
        }

        internal IDictionary<string, object> ValuePairs
        {
            get { return _values; }
        }

        internal IEnumerable<KeyValuePair<string, object>> AllPairs
        {
            get { return _ids.Concat(_values); }
        }

        #endregion

        #region Constructor

        internal PropertyContainer()
        {
            _ids = new Dictionary<string, object>();
            _values = new Dictionary<string, object>();
        }

        #endregion

        #region Methods

        internal void AddId(string name, object value)
        {
            _ids.Add(name, value);
        }

        internal void AddValue(string name, object value)
        {
            _values.Add(name, value);
        }

        #endregion
    }

}
