using System.ComponentModel.DataAnnotations;

namespace Entidade.DTO
{
    public class ReferenciaDTO
    {
        [Key]
        public int Código { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' está vazio")]
        public string Nome { get; set; }
    }

    public class ReferenciaNomeDTO
    {
        public string Nome { get; set; }
    }
}
