namespace DesignPattern.Estrutural.Facade.Domain
{
    public class PagamentoCartaoCreditoServices : IPagamento
    {
        private readonly IPagamentoCartaoCreditorFacade _pagamentoCartaoCreditorFacade;
        public PagamentoCartaoCreditoServices(IPagamentoCartaoCreditorFacade pagamentoCartaoCreditorFacade)
        {
            _pagamentoCartaoCreditorFacade = pagamentoCartaoCreditorFacade;
        }

        public Pagamento RealizarPagamento(Pedido pedido, Pagamento pagamento)
        {
            pagamento.Valor = pedido.Produtos.Sum(p => p.Valor);
            Console.WriteLine("Iniciando Pagamento via Cartão de Crédito - Valor R$ " + pagamento.Valor);

            if (_pagamentoCartaoCreditorFacade.RealizarPagamento(pedido, pagamento))
            {
                pagamento.Status = "Pago via Cartão de Crédito";
                return pagamento;
            }

            pagamento.Status = "Cartão de Crédito Recusado!";
            return pagamento;
        }
    }
}
