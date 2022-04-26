using System;

namespace Entidade.DTO
{
    public class AdicionarAmostraDTO
    {
        public AdicionarAmostraDTO(string numero, string nome, string phAgua, string diluicao, string fosforo, string potassio, string calcio, string aluminio, string magnesio, string acidezPotencial, string zinco, string cobre, string ferro, string manganes, string argilaInicio, string argilaFim, string areiaInicio, string areiaFim, string silteInicio, string silteFim, string boro, string enxofre, string materiaOrganica)
        {
            Numero = numero;
            Nome = nome;
            PhAgua = phAgua;
            Diluicao = diluicao;
            Fosforo = fosforo;
            Potassio = potassio;
            Calcio = calcio;
            Aluminio = aluminio;
            Magnesio = magnesio;
            AcidezPotencial = acidezPotencial;
            Zinco = zinco;
            Cobre = cobre;
            Ferro = ferro;
            Manganes = manganes;
            ArgilaInicio = argilaInicio;
            ArgilaFim = argilaFim;
            AreiaInicio = areiaInicio;
            AreiaFim = areiaFim;
            SilteInicio = silteInicio;
            SilteFim = silteFim;
            Boro = boro;
            Enxofre = enxofre;
            MateriaOrganica = materiaOrganica;
        }

        public AdicionarAmostraDTO()
        {
        }

        public string Numero { get; set; }
        public string Nome { get; set; }
        public string PhAgua { get; set; }
        public string Diluicao { get; set; }
        public string Fosforo { get; set; }
        public string Potassio { get; set; }
        public string Calcio { get; set; }
        public string Aluminio { get; set; }
        public string Magnesio { get; set; }
        public string AcidezPotencial { get; set; }
        public string Zinco { get; set; }
        public string Cobre { get; set; }
        public string Ferro { get; set; }
        public string Manganes { get; set; }
        public string ArgilaInicio { get; set; }
        public string ArgilaFim { get; set; }
        public string AreiaInicio { get; set; }
        public string AreiaFim { get; set; }
        public string SilteInicio { get; set; }
        public string SilteFim { get; set; }
        public string Boro { get; set; }
        public string Enxofre { get; set; }
        public string MateriaOrganica { get; set; }
    }



    public class AmostraImpressaoLaudoDTO
    {
        public string Numero { get; set; }
        public string Nome { get; set; }
        public string PhAgua { get; set; }
        public string Diluicao { get; set; }
        public string Fosforo { get; set; }
        public string Potassio { get; set; }
        public string Calcio { get; set; }
        public string Aluminio { get; set; }
        public string Magnesio { get; set; }
        public string AcidezPotencial { get; set; }
        public string SB { get; set; }
        public string ti { get; set; }
        public string T { get; set; }
        public string V { get; set; }
        public string m { get; set; }
        public string Zinco { get; set; }
        public string Cobre { get; set; }
        public string Ferro { get; set; }
        public string Manganes { get; set; }
        public string Argila { get; set; }
        public string Areia { get; set; }
        public string Silte { get; set; }
        public string Boro { get; set; }
        public string Enxofre { get; set; }
        public string MateriaOrganica { get; set; }
        public string TonHa { get; set; }

        public bool Basica { get; set; }
        public bool Completa { get; set; }
        public bool Fisica { get; set; }
        public bool Opcional { get; set; }

    }
}