using Entidade;
using Microsoft.EntityFrameworkCore;
using Repositorio.Config;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class AmostraRepositorio
    {
        public AmostraRepositorio() { }

        public List<AmostraEntidade> ObterAmostrarPorIdAnalise(int idAnalise)
        {
            using (var db = new ContextDB())
            {
                var query = db.Amostras
                                .Where(w => w.Analises.IdAnalise == idAnalise)
                                .ToList();

                return query;
            }
        }

        public int Salvar(AmostraEntidade amostra, int IdAnalise)
        {
            amostra.Analises = new AnaliseRepositorio().ObterUmPorCodigo(IdAnalise);

            using (var db = new ContextDB())
            {
                db.Entry<AmostraEntidade>(amostra).State = EntityState.Added;
                db.SaveChanges();
            }

            return amostra.IdAmostras;
        }

        public AmostraEntidade RecuperarParaExcluir(int idAnalise)
        {
            using (var db = new ContextDB())
            {
                var query = db.Amostras
                                .Where(w => w.Analises.IdAnalise == idAnalise)
                                .FirstOrDefault();

                return query;
            }
        }

        public int Excluir(AmostraEntidade amostra)
        {
            using (var db = new ContextDB())
            {
                db.Remove(amostra);
                db.SaveChanges();
            }

            return amostra.IdAmostras;
        }
    }
}
