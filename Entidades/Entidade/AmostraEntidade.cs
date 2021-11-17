using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class AmostraEntidade
    {
        [Key]
        public int IdAmostras { get; set; }

        [MaxLength(100)]
        public string NomeAmostra { get; set; }

        [MaxLength(10)]
        public string pH { get; set; }

        [MaxLength(10)]
        public string P { get; set; }

        [MaxLength(10)]
        public string K { get; set; }

        [MaxLength(10)]
        public string Ca { get; set; }

        [MaxLength(10)]
        public string Mg { get; set; }

        [MaxLength(10)]
        public string Al { get; set; }

        [MaxLength(10)]
        public string AlH { get; set; }

        [MaxLength(10)]
        public string SB { get; set; }

        [MaxLength(10)]
        public string ti { get; set; }

        [MaxLength(10)]
        public string T { get; set; }

        [MaxLength(10)]
        public string V { get; set; }

        [MaxLength(10)]
        public string m { get; set; }

        [MaxLength(10)]
        public string Zn { get; set; }

        [MaxLength(10)]
        public string Cu { get; set; }

        [MaxLength(10)]
        public string Fe { get; set; }

        [MaxLength(10)]
        public string Mn { get; set; }

        [MaxLength(10)]
        public string B { get; set; }

        [MaxLength(10)]
        public string S { get; set; }

        [MaxLength(10)]
        public string MO { get; set; }

        [MaxLength(10)]
        public string Argila { get; set; }

        [MaxLength(10)]
        public string Areia { get; set; }

        [MaxLength(10)]
        public string Silte { get; set; }

        [MaxLength(10)]
        public string TonHa { get; set; }

        [MaxLength(10)]

        public AnaliseEntidade Analises { get; set; }
    }
}
