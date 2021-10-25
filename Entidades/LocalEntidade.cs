using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class LocalEntidade
    {
        [Key]
        public int IdLocal { get; set; }

        public string Fazenda { get; set; }

        public string Municipio { get; set; }

        public bool Excluido { get; set; }

        public SolicitanteEntidade Solicitantes { get; set; }
    }
}
