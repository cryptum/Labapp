using System.ComponentModel.DataAnnotations;

namespace Entidade.DTO
{
    public class CulturaDTO
    {
        [Key]
        public int Código { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' está vazio")]
        public string Nome { get; set; }
    }

    public class CulturaNomeDTO
    {
        public string Nome { get; set; }
    }
}
