using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade
{
    public class CulturaEntidade
    {
        [Key]
        public int IdCultura { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}
