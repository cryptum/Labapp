using System;

namespace Entidade.DTO
{
    public class AnaliseDTO
    {
        public int Código { get; set; }

        public ProprietarioEntidade Proprietário { get; set; }

        public string Fazenda { get; set; }

        public string Município { get; set; }

        public string Referência { get; set; }

        public string Cultura { get; set; }

        public string TipoSolicitação { get; set; }

        public DateTime DataCriado { get; set; }

        public DateTime DataUltimaAtualizacao { get; set; }
    }

    public class AnaliseObterTodosDTO
    {
        public int Código { get; set; }

        public string Analise { get; set; }

        public string Proprietário { get; set; }

        public string Fazenda { get; set; }

        public string Referência { get; set; }

        public string Cultura { get; set; }

        public string Solicitação { get; set; }
    }

    public class AnaliseObterTodosImcompletoDTO
    {
        public int Código { get; set; }

        public string Análise { get; set; }

        public string Fazenda { get; set; }

        public string Referência { get; set; }

        public string Cultura { get; set; }
        public string Completo { get; set; }
    }

    public class AnaliseObterTodosCompletoDTO
    {
        public int Código { get; set; }

        public string Análise { get; set; }

        public string Proprietário { get; set; }

        public string Fazenda { get; set; }

        public string Referência { get; set; }

        public string Cultura { get; set; }

        public string Solicitação { get; set; }

        public string Completo { get; set; }
    }
}
