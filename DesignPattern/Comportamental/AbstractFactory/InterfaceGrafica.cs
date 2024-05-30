using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.AbstractFactory
{
    // Client
    public class InterfaceGrafica
    {
        private readonly InterfaceSO _interfaceSO;
        public InterfaceGrafica(InterfaceGraficaFactory factory, InterfaceSO interfaceSO)
        {
            _interfaceSO = factory.CriarInterface(interfaceSO.TipoInterface, interfaceSO.DescricaoOS);
        }

        public void ClickBotao()
        {
            _interfaceSO.Botao(_interfaceSO.TipoInterface);
            _interfaceSO.Sobre(_interfaceSO.DescricaoOS);
        }
    }

    public class CriarInterface
    {
        public static InterfaceGrafica Criar(InterfaceSO interfaceSO)
        {
            switch (interfaceSO.TipoInterface)
            {
                case ETipoInterface.Windows:
                    return new InterfaceGrafica(new InterfaceGraficaWindowsFactory(), interfaceSO);
                case ETipoInterface.MacOS:
                    return new InterfaceGrafica(new InterfaceGraficaWindowsFactory(), interfaceSO);
                default:
                    throw new ApplicationException("Opção inválida.");
            }
        }
    }
}
