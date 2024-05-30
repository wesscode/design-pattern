using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.AbstractFactory
{
    // Concret factory
    public class InterfaceGraficaWindowsFactory : InterfaceGraficaFactory
    {
        public override InterfaceSO CriarInterface(ETipoInterface tipoInterface, string descricaoOS)
        {
            return CriarInterfaceGrafica.Criar(tipoInterface, descricaoOS);
        }
    }
}
