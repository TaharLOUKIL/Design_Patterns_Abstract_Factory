using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AbstractFactory
{
    class SqlServerDatabase : Database
    {
        private System.Data.Common.DbConnection _Connection = null;
        private System.Data.Common.DbCommand _Command = null;

        public override System.Data.Common.DbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnection"].ConnectionString;
                    _Connection = new SqlConnection(connectionString);
                }
                return (_Connection);
            }
            set
            {
                _Connection = value;
            } 
        }

        public override System.Data.Common.DbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new SqlCommand();
                    _Command.Connection = Connection;
                }
                return _Command;
            }
            set
            {
                _Command = value;
           
            }

        }
    
    }
}
