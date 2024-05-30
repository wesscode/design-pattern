using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.AbstractFactory
{
    // Concret factory
    public class CriarInterfaceGraficaMacOS : CriarInterfaceGrafica
    {
        public override CriarInterfaceGrafica CriarInterface(ETipoInterface tipoInterface)
        {
            throw new NotImplementedException();
        }
    }
}
