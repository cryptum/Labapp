using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class ReferenciaEntidade
    {
        [Key]
        public int IdReferencia { get; set; }
        public string Nome { get; set; }
    }
}
