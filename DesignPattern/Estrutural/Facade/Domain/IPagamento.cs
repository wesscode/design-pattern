namespace DesignPattern.Estrutural.Facade.Domain
{
    public interface IPagamento
    {
        Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
