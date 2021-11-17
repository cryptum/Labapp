using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class TipoAnaliseEntidade
    {
        // EX: Agua
        [Key]
        public int IdTipoAnalise { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
