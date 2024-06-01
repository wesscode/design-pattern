using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.FactoryMethod
{
    public class OracleConnector : DbConnector
    {
        public OracleConnector(string connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
        }
        public override Connection Connect()
        {
            Console.WriteLine("Conectando ao banco Oracle...");
            var connection = new Connection(ConnectionString);
            connection.Open();

            return connection;
        }
    }
}
