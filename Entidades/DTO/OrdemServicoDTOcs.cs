namespace Entidade.DTO
{
    public class OrdemServicoDTO
    {
        public string Numero { get; set; }
        public string Cliente { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }
        public string NumeroOrdemDeCompra { get; set; }

        public string ValorTotalDaPrestacao { get; set; }
        public string EntreguePor { get; set; }
        public string DataEntrada { get; set; }
        public string HoraEntrada { get; set; }
        public string DataResultado { get; set; }
        public string HoraResultado { get; set; }
        public string ReponsavelRecebimento { get; set; }
    }

    public class DataGridOrdemServicoDTO
    {
        public string NAmostra { get; set; }
        public string IdCliente { get; set; }
        public string TipoDeAmostra { get; set; }
        public string AnalideSolicitadas { get; set; }
        public string ValorDoPreparo { get; set; }
        public string ValorDaAnalise { get; set; }
        public string ValorTotal { get; set; }
    }
}
