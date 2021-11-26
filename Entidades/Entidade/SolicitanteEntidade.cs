using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class SolicitanteEntidade
    {
        [Key]
        public int IdSolicitante { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [MaxLength(30)]
        public string Cpf { get; set; }

        [MaxLength(100)]
        public string Observacao { get; set; }

        public bool Excluido { get; set; }

        public ICollection<LocalEntidade> Locais { get; set; }

        public ICollection<AnaliseEntidade> Analises { get; set; }

    }
}
