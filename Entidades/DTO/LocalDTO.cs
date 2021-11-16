using System.ComponentModel.DataAnnotations;

namespace Entidade.DTO
{
    public class LocalDTO
    {
        [Key]
        public int Código { get; set; }

        public string Fazenda { get; set; }

        public string Município { get; set; }
    }
}
