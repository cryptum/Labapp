using System.ComponentModel.DataAnnotations;

namespace Entidade.DTO
{
    public class SolicitanteDTO
    {
        [Key]
        public int Código { get; set; }

        [Required(ErrorMessage = "O campo 'Nome' está vazio")]
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Observação { get; set; }

        public int Fazendas { get; set; }
    }
}
