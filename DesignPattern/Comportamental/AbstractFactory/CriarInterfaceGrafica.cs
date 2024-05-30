using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.AbstractFactory
{
    //Abstract factory
    public abstract class CriarInterfaceGrafica
    {
        public abstract CriarInterfaceGrafica CriarInterface(ETipoInterface tipoInterface);
    }
}
