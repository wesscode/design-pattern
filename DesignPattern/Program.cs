// See https://aka.ms/new-console-template for more information




/*
    desenvolver sistema para interface gráficas de usuário que precisa funcionar em diferentes
    sistemas operacionais como windows e macOS. Cada sistema operacional tem seu próprio estilo
    de botões e caixas de dialogos e outros elementos de interface.         
 */



using DesignPattern.Comportamental.AbstractFactory;

List<InterfaceSO> interfaceSOs = new List<InterfaceSO>()
{
   CriarInterfaceGrafica.Criar(ETipoInterface.Windows, "Windows é um sistema que lhe garante a alta produtividade."),
   CriarInterfaceGrafica.Criar(ETipoInterface.MacOS, "Mac é um sistema ótimizado.")
};

interfaceSOs.ForEach(v => CriarInterface.Criar(v).ClickBotao());