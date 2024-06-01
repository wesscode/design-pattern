using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.FactoryMethod
{
    // Abstract Creator
    public abstract class DbFactory
    {
        //Factory method
        public abstract DbConnector CreateConnector(string connectionString);

        public static DbFactory Database(EDataBase dataBase)
        {
            return dataBase switch
            {
                EDataBase.SqlServer => new SqlFactory(),
                EDataBase.Oracle => new OracleFactory(),
                _ => throw new ApplicationException("Opção inválida."),
            };
        }
    }
}
