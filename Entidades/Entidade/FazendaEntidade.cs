using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class FazendaEntidade
    {
        [Key]
        public int IdFazenda { get; set; }

        [MaxLength(120)]
        public string Fazenda { get; set; }

        [MaxLength(120)]
        public string Municipio { get; set; }

        public bool Excluido { get; set; }

        public ProprietarioEntidade Proprietarios { get; set; }
    }
}
