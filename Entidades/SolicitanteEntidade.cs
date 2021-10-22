using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class SolicitanteEntidade
    {
        [Key]
        public int IdSolicitante { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Observacao { get; set; }
        public bool Excluido { get; set; }

        public ICollection<LocalEntidade> Locais{ get; set; }
        public ICollection<AnaliseEntidade> Analises { get; set; }

    }
}
