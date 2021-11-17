using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class TipoSolicitacaoEntidade
    {
        [Key]
        public int IdTipoSolicitacao { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
