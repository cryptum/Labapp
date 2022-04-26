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

        public bool? Finalizada { get; set; }

        public ICollection<AmostraEntidade> Amostras { get; set; }

        public DateTime DataCriado { get; set; }
    }
}
