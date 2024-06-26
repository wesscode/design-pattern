﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Criacional.AbstractFactory
{
    /*
    desenvolver sistema para interface gráficas de usuário que precisa funcionar em diferentes
    sistemas operacionais como windows e macOS. Cada sistema operacional tem seu próprio estilo
    de botões e caixas de dialogos e outros elementos de interface.         
    */
    public class ExecutarAbstractFactory
    {
        public static void Executar()
        {
            List<InterfaceSO> interfaceSOs = new List<InterfaceSO>()
            {
               CriarInterfaceGrafica.Criar(ETipoInterface.Windows, "Windows é um sistema que lhe garante a alta produtividade."),
               CriarInterfaceGrafica.Criar(ETipoInterface.MacOS, "Mac é um sistema ótimizado.")
            };

            interfaceSOs.ForEach(v => CriarInterface.Criar(v).ClickBotao());
        }
    }
}