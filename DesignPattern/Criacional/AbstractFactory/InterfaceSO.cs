using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.AbstractFactory
{
    // Abstract Product
    public abstract class InterfaceSO
    {
        protected InterfaceSO(ETipoInterface tipoInterface, string descricaoOS)
        {
            TipoInterface = tipoInterface;
            DescricaoOS = descricaoOS;
        }
        public ETipoInterface TipoInterface { get; set; }
        public string DescricaoOS { get; set; }

        public abstract void Botao(ETipoInterface TipoInterface);
        public abstract void Sobre(string DescricaoOS);
    }

    // Concret Product
    public class InterfaceGraficaWindows : InterfaceSO
    {
        public InterfaceGraficaWindows(ETipoInterface tipoInterface, string descricaoOS) : base(tipoInterface, descricaoOS) { }

        public override void Botao(ETipoInterface tipoInterface)
        {
            Console.WriteLine($"Botão {tipoInterface}");
        }

        public override void Sobre(string descricaoOS)
        {
            Console.WriteLine($"Sobre: {descricaoOS}");
        }
    }

    // Concret Product
    public class InterfaceGraficaMacOS : InterfaceSO
    {
        public InterfaceGraficaMacOS(ETipoInterface tipoInterface, string descricaoOS) : base(tipoInterface, descricaoOS) { }

        public override void Botao(ETipoInterface tipoInterface)
        {
            Console.WriteLine($"Botão {tipoInterface}");
        }

        public override void Sobre(string descricaoOS)
        {
            Console.WriteLine($"Sobre: {descricaoOS}");
        }
    }

    public class CriarInterfaceGrafica
    {
        public static InterfaceSO Criar(ETipoInterface tipoInterface, string descricaoOS)
        {
            return tipoInterface switch
            {
                ETipoInterface.Windows => new InterfaceGraficaWindows(tipoInterface, descricaoOS),
                ETipoInterface.MacOS => new InterfaceGraficaMacOS(tipoInterface, descricaoOS),
                _ => throw new ApplicationException("Opção inválida."),
            };
        }
    }
}
