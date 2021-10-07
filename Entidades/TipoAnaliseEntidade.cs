using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class TipoAnaliseEntidade
    {
        // EX: Agua
        [Key]
        public int IdTipoAnalise { get; set; }
        public string Nome { get; set; }
    }
}
