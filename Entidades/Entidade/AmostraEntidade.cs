using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class AmostraEntidade
    {
        [Key]
        public int IdAmostras { get; set; }

        public string NomeAmostra { get; set; }
        public string pH { get; set; }
        public string P { get; set; }
        public string K { get; set; }
        public string Ca { get; set; }
        public string Mg { get; set; }
        public string Al { get; set; }
        public string AlH { get; set; }
        public string SB { get; set; }
        public string ti { get; set; }
        public string T { get; set; }
        public string V { get; set; }
        public string m { get; set; }
        public string Zn { get; set; }
        public string Cu { get; set; }
        public string Fe { get; set; }
        public string Mn { get; set; }
        public string B { get; set; }
        public string S { get; set; }
        public string MO { get; set; }
        public string Argila { get; set; }
        public string Areia { get; set; }
        public string Silte { get; set; }
        public string TonHa { get; set; }

        public AnaliseEntidade Analises { get; set; }
    }
}
