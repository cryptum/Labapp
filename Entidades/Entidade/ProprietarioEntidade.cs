using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class ProprietarioEntidade
    {
        [Key]
        public int IdProprietario { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nome { get; set; }

        [MaxLength(30)]
        public string Cpf { get; set; }

        [MaxLength(100)]
        public string Observacao { get; set; }

        public bool Excluido { get; set; }

        public ICollection<FazendaEntidade> Fazendas { get; set; }

        public ICollection<AnaliseEntidade> Analises { get; set; }

    }
}
