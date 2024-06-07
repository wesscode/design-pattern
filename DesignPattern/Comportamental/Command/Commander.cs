namespace DesignPattern.Comportamental.Command
{
    public abstract class Commander
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
