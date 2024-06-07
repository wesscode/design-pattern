using DesignPattern.Estrutural.Facade.CrossCutting;
using DesignPattern.Estrutural.Facade.Domain;

namespace DesignPattern.Comportamental.Strategy
{
    public class PagamentoFactory
    {
        // Nesse caso seria necessário usar um tipo de Service Locator
        // Ou injetar todas as instâncias para retornar apenas uma
        public static IPagamento CreatePagamento(EMeioPagamento meioPagamento)
        {
            switch (meioPagamento)
            {
                case EMeioPagamento.CartaoCredito:
                    return new PagamentoCartaoCreditoService(
                               new PagamentoCartaoCreditoFacade(
                    new PayPalGateway(),
                               new ConfigurationManager()));

                case EMeioPagamento.Boleto:
                    return new PagamentoBoletoService(new PagamentoBoletoFacade());

                case EMeioPagamento.TransferenciaBancaria:
                    return new PagamentoTransferenciaService(new PagamentoTransferenciaFacade());

                default:
                    throw new ApplicationException("Meio de Pagamento não conhecido");
            }
        }
    }
}
