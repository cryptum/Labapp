using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class AnaliseEntidade
    {
        [Key]
        public int IdAnalise { get; set; }

        [MaxLength(50)]
        public string NomeAnalise { get; set; }

        public SolicitanteEntidade Solicitantes { get; set; }

        [MaxLength(120)]
        public string Local { get; set; }

        [MaxLength(120)]
        public string Municipio { get; set; }

        [MaxLength(100)]
        public string Referencia { get; set; }

        [MaxLength(100)]
        public string Cultura { get; set; }

        [MaxLength(100)]
        public string TipoSolicitacao { get; set; }

        [MaxLength(100)]
        public string NomeAmostra1 { get; set; }

        [MaxLength(100)]
        public string NomeAmostra2 { get; set; }

        [MaxLength(100)]
        public string NomeAmostra3 { get; set; }

        [MaxLength(100)]
        public string NomeAmostra4 { get; set; }

        public bool? Completa { get; set; }

        public ICollection<AmostraEntidade> Amostras { get; set; }

        public DateTime DataCriado { get; set; }
    }
}
