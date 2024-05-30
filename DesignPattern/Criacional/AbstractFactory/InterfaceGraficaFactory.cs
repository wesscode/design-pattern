using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.AbstractFactory
{
    //Abstract factory
    public abstract class InterfaceGraficaFactory
    {
        //devolve a instância do objeto que quero criar.
        public abstract InterfaceSO CriarInterface(ETipoInterface tipoInterface, string descricaoOS);
    }
}
