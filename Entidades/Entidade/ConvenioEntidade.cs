using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class ConvenioEntidade
    {
        [Key]
        public int IdConvenio { get; set; }

        [MaxLength(100)]
        public string Nome { get; set; }
    }
}
