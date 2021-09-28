using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class AnaliseEntidade
    {
        [Key]
        public int IdAnalise { get; set; }
        public DateTime DataEntrada { get; set; }
    }
}
