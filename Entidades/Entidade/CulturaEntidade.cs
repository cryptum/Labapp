using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class CulturaEntidade
    {
        [Key]
        public int IdCultura { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
