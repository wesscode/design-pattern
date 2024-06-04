namespace DesignPattern.Estrutural.Facade.Domain
{
    public class Pagamento
    {
        public string Status { get; set; }
        public decimal Valor { get; set; }
        public EMeioPagamento MeioPagamento { get; set; }

        // Possiveis meios de pagamento implementados direto 
        // na classe pagamento por brevidade do exemplo
        public string CartaoCredito { get; set; }
        public string LinhaDigitavelBoleto { get; set; }
        public string ConfirmacaoTransferencia { get; set; }
    }
}
