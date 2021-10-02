using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Entidade.DTO
{
    public class SolicitanteDTO
    {
        [Key]
        public int Código { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' está vazio")]
        public string Nome { get; set; }

        public string Observacao { get; set; }

        public int Fazendas { get; set; }
    }
}
