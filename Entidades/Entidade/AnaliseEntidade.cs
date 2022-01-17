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

        public ProprietarioEntidade Proprietarios { get; set; }

        [MaxLength(120)]
        public string Fazenda { get; set; }

        [MaxLength(120)]
        public string Municipio { get; set; }

        [MaxLength(100)]
        public string Referencia { get; set; }

        [MaxLength(100)]
        public string Cultura { get; set; }

        [MaxLength(100)]
        public string Convenio { get; set; }

        [MaxLength(100)]
        public string NomeAmostra1 { get; set; }

        [MaxLength(100)]
        public string NumeroAmostra1 { get; set; }

        [MaxLength(100)]
        public string NomeAmostra2 { get; set; }

        [MaxLength(100)]
        public string NumeroAmostra2 { get; set; }

        [MaxLength(100)]
        public string NomeAmostra3 { get; set; }

        [MaxLength(100)]
        public string NumeroAmostra3 { get; set; }

        [MaxLength(100)]
        public string NomeAmostra4 { get; set; }

        [MaxLength(100)]
        public string NumeroAmostra4 { get; set; }

        public bool? Completa { get; set; }

        public ICollection<AmostraEntidade> Amostras { get; set; }

        public DateTime DataCriado { get; set; }
    }
}
