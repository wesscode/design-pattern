namespace DesignPattern.Estrutural.Facade.Domain
{
    public interface IPagamentoCartaoCreditorFacade
    {
        bool RealizarPagamento(Pedido pedido, Pagamento pagamento);
    }
}
