using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class ReferenciaEntidade
    {
        [Key]
        public int IdReferencia { get; set; }
        public string Nome { get; set; }
    }
}
