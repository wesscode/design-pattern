using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.FactoryMethod
{
    public abstract class DbConnector
    {
        protected DbConnector(string connectionString) 
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public abstract Connection Connect();
    }
}
