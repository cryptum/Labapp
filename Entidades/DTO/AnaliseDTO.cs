using System;

namespace Entidade.DTO
{
    public class AnaliseDTO
    {
        public int Código { get; set; }

        public SolicitanteEntidade Solicitante { get; set; }

        public string Local { get; set; }

        public string Municipio { get; set; }

        public string Referencia { get; set; }

        public string Cultura { get; set; }

        public string TipoSolicitacao { get; set; }

        public DateTime DataCriado { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; }
    }

    public class AnaliseObterTodosDTO
    {
        public int Código { get; set; }

        public string Solicitante { get; set; }

        public string Local { get; set; }

        public string Referencia { get; set; }

        public string Cultura { get; set; }

        public string TipoSolicitacao { get; set; }
    }
}
