using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class ReferenciaEntidade
    {
        [Key]
        public int IdReferencia { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
