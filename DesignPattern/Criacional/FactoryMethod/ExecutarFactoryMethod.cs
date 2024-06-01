using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.FactoryMethod
{
    public class ExecutarFactoryMethod
    {
        public static void Executar()
        {
            var sqlCn = DbFactory.Database(EDataBase.SqlServer)
                                 .CreateConnector("minhaConnectionString")
                                 .Connect();

            sqlCn.ExecuteCommand("Select * from tabelaSQL");
            sqlCn.Close();

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("");

            var oracleCn = DbFactory.Database(EDataBase.Oracle)
                                    .CreateConnector("minhaConnectionString")
                                    .Connect();

            oracleCn.ExecuteCommand("select * from tabelaOracle");
            oracleCn.Close();
        }
    }
}
