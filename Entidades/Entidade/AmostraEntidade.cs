using System.ComponentModel.DataAnnotations;

namespace Entidade
{
    public class AmostraEntidade
    {
        public AmostraEntidade(string numeroAmostra, string nomeAmostra, string ph_Agua, string diluicao, string p_Fosforo, string k_Potassio, string ca_Calcio, string mg_Magnesio, string al_Aluminio, string alh_AcidezPotencial, string zn_Zinco, string cu_Cobre, string fe_Ferro, string mn_manganes, string argila_Inicio, string argila_Fim, string areia_Inicio, string areia_Fim, string silte_Inicio, string silte_Fim, string b_Boro, string enxofre, string mo_MateriaOrganica)
        {
            NumeroAmostra = numeroAmostra;
            NomeAmostra = nomeAmostra;
            Ph_Agua = ph_Agua;
            Diluicao = diluicao;
            P_Fosforo = p_Fosforo;
            K_Potassio = k_Potassio;
            Ca_Calcio = ca_Calcio;
            Mg_Magnesio = mg_Magnesio;
            Al_Aluminio = al_Aluminio;
            Alh_AcidezPotencial = alh_AcidezPotencial;
            Zn_Zinco = zn_Zinco;
            Cu_Cobre = cu_Cobre;
            Fe_Ferro = fe_Ferro;
            Mn_manganes = mn_manganes;
            Argila_Inicio = argila_Inicio;
            Argila_Fim = argila_Fim;
            Areia_Inicio = areia_Inicio;
            Areia_Fim = areia_Fim;
            Silte_Inicio = silte_Inicio;
            Silte_Fim = silte_Fim;
            B_Boro = b_Boro;
            S_Enxofre = enxofre;
            Mo_MateriaOrganica = mo_MateriaOrganica;
        }

        public AmostraEntidade()
        {
        }

        [Key]
        public int IdAmostras { get; set; }

        [MaxLength(50)]
        public string NumeroAmostra { get; set; }

        [MaxLength(50)]
        public string NomeAmostra { get; set; }

        [MaxLength(10)]
        public string Ph_Agua { get; set; }

        [MaxLength(10)]
        public string Diluicao { get; set; }

        [MaxLength(10)]
        public string P_Fosforo { get; set; }

        [MaxLength(10)]
        public string K_Potassio { get; set; }

        [MaxLength(10)]
        public string Ca_Calcio { get; set; }

        [MaxLength(10)]
        public string Mg_Magnesio { get; set; }

        [MaxLength(10)]
        public string Al_Aluminio { get; set; }

        [MaxLength(10)]
        public string Alh_AcidezPotencial { get; set; }

        [MaxLength(10)]
        public string Zn_Zinco { get; set; }

        [MaxLength(10)]
        public string Cu_Cobre { get; set; }

        [MaxLength(10)]
        public string Fe_Ferro { get; set; }

        [MaxLength(10)]
        public string Mn_manganes { get; set; }


        [MaxLength(10)]
        public string Argila_Inicio { get; set; }

        [MaxLength(10)]
        public string Argila_Fim { get; set; }

        [MaxLength(10)]
        public string Areia_Inicio { get; set; }

        [MaxLength(10)]
        public string Areia_Fim { get; set; }

        [MaxLength(10)]
        public string Silte_Inicio { get; set; }

        [MaxLength(10)]
        public string Silte_Fim { get; set; }


        [MaxLength(10)]
        public string B_Boro { get; set; }

        [MaxLength(10)]
        public string S_Enxofre { get; set; }

        [MaxLength(10)]
        public string Mo_MateriaOrganica { get; set; }

        public bool Basica { get; set; }

        public bool Completa { get; set; }

        public bool Fisica { get; set; }

        public bool Opcional { get; set; }

        public AnaliseEntidade Analises { get; set; }
    }
}
