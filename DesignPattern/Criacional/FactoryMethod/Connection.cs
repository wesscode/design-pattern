using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.FactoryMethod
{
    public class Connection
    {
        public Connection(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
        public bool Opened { get; set; }

        public void ExecuteCommand(string command)
        {
            Console.WriteLine("Executando Commando: " + command);
        }
        public void Open()
        {
            Opened = true;
            Console.WriteLine("Conexão aberta");
        }
        public void Close()
        {
            Console.WriteLine("Conexão fechada");
        }
    }
}
