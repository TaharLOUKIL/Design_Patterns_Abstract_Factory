using System.Data.Common;

namespace AbstractFactory
{
    public abstract class Database
    {
        public virtual DbConnection Connection { get; set;}
        public virtual DbCommand    Command { get; set; }
             
    }
}
