using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Comportamental.AbstractFactory
{
    // Abstract Product
    public abstract class InterfaceGrafica
    {
        protected InterfaceGrafica(ETipoInterface tipoInterface, string nomeOS)
        {
            TipoInterface = tipoInterface;
            NomeOS = nomeOS;
        }
        public ETipoInterface TipoInterface { get; set; }
        public string NomeOS { get; set; }

        public abstract void Botao(ETipoInterface TipoInterface);
        public abstract void Dialogo(string NomeOS);
    }

    // Concret Product
    public class InterfaceGraficaWindows : InterfaceGrafica
    {
        public InterfaceGraficaWindows(ETipoInterface tipoInterface, string nomeOS) : base(tipoInterface, nomeOS) { }

        public override void Botao(ETipoInterface tipoInterface)
        {
            Console.WriteLine($"Botão {tipoInterface}");
        }

        public override void Dialogo(string nomeOS)
        {
            Console.WriteLine($"Botão {nomeOS}");
        }
    }

    // Concret Product
    public class InterfaceGraficaMacOS : InterfaceGrafica
    {
        public InterfaceGraficaMacOS(ETipoInterface tipoInterface, string nomeOS) : base(tipoInterface, nomeOS) { }

        public override void Botao(ETipoInterface tipoInterface)
        {
            Console.WriteLine($"Botão {tipoInterface}");
        }

        public override void Dialogo(string nomeOS)
        {
            Console.WriteLine($"Dialogo: {nomeOS}");
        }
    }


}
