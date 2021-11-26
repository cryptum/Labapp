using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class LocalEntidade
    {
        [Key]
        public int IdLocal { get; set; }

        [MaxLength(120)]
        public string Fazenda { get; set; }

        [MaxLength(120)]
        public string Municipio { get; set; }

        public bool Excluido { get; set; }

        public SolicitanteEntidade Solicitantes { get; set; }
    }
}
