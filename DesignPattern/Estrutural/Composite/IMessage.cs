namespace DesignPattern.Estrutural.Composite
{
    public interface IMessage
    {
        string Nome { get; set; }
        void ExibirMensagens(int sub);
    }
}
