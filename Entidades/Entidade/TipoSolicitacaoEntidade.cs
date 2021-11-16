using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class TipoSolicitacaoEntidade
    {
        [Key]
        public int IdTipoSolicitacao { get; set; }
        public string Nome { get; set; }
    }
}
