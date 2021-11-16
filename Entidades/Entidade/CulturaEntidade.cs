using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

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
