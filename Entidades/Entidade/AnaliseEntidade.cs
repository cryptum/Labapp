using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class AnaliseEntidade
    {
        [Key]
        public int IdAnalise { get; set; }

        public string NomeAnalise { get; set; }

        public SolicitanteEntidade Solicitantes { get; set; }

        public string Local { get; set; }

        public string Municipio { get; set; }

        public string Referencia { get; set; }

        public string Cultura { get; set; }

        public string TipoSolicitacao { get; set; }

        public string NomeAmostra1 { get; set; }

        public string NomeAmostra2 { get; set; }

        public string NomeAmostra3 { get; set; }

        public string NomeAmostra4 { get; set; }

        public bool? Completa { get; set; }

        public ICollection<AmostraEntidade> Amostras { get; set; }

        public DateTime DataCriado { get; set; }
    }
}
