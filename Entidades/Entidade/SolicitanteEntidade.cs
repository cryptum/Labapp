using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class SolicitanteEntidade
    {
        [Key]
        public int IdSolicitante { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Observacao { get; set; }

        public bool Excluido { get; set; }

        public ICollection<LocalEntidade> Locais { get; set; }

        public ICollection<AnaliseEntidade> Analises { get; set; }

    }
}
