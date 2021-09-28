using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class TipoSolicitacaoEntidade
    {
        [Key]
        public Guid IdTipoSolicitacao { get; set; }
        public string Nome { get; set; }
    }
}
