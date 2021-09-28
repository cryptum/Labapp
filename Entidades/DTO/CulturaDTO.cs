using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.DTO
{
    public class CulturaDTO
    {
        [Key]
        public int Código { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' está vazio")]
        public string Nome { get; set; }
    }
}
