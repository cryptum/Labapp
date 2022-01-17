using Entidade;
using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class AnaliseNegocio
    {
        public AnaliseNegocio() { }

        public List<AnaliseObterTodosImcompletoDTO> ObterTodosImcompleta()
        {
            return new AnaliseRepositorio().ObterTodosImcompleta();
        }
        public List<AnaliseObterTodosCompletoDTO> ObterTodosCompletos()
        {
            return new AnaliseRepositorio().ObterTodosCompletos();
        }

        public AnaliseEntidade ObterUmPorCodigo(int id)
        {
            return new AnaliseRepositorio().ObterUmPorCodigo(id);
        }

        public List<AnaliseObterTodosDTO> ObterListaPorNomeProprietario(string nome)
        {
            return new AnaliseRepositorio().ObterListaPorNomeProprietario(nome);
        }

        public List<AnaliseObterTodosDTO> ObterListaPorCpfProprietario(string nome)
        {
            return new AnaliseRepositorio().ObterListaPorCpfProprietario(nome);
        }


        public int Salvar(string nomeAnalise, int idProprietario, string local, string referencia, string cultura, string tipoSolicitacao, string nomeAmostra1, string numeroAmostra1, string nomeAmostra2, string numeroAmostra2, string nomeAmostra3, string numeroAmostra3, string nomeAmostra4, string numeroAmostra4)
        {
            AnaliseEntidade analise = new AnaliseEntidade();
            analise.NomeAnalise = nomeAnalise.Trim();
            analise.Fazenda = local;
            analise.Referencia = referencia;
            analise.Cultura = cultura;
            analise.Convenio = tipoSolicitacao;
            analise.DataCriado = DateTime.Now;
            analise.NomeAmostra1 = nomeAmostra1;
            analise.NumeroAmostra1 = numeroAmostra1;
            analise.NomeAmostra2 = nomeAmostra2;
            analise.NumeroAmostra2 = numeroAmostra2;
            analise.NomeAmostra3 = nomeAmostra3;
            analise.NumeroAmostra3 = numeroAmostra3;
            analise.NomeAmostra4 = nomeAmostra4;
            analise.NumeroAmostra4 = numeroAmostra4;
            analise.Completa = false;
            return new AnaliseRepositorio().Salvar(analise, idProprietario);
        }

        public int EditarNomesDasAmostras(AnaliseEntidade analise)
        {
            return new AnaliseRepositorio().Editar(analise);
        }

        public int Excluir(int Id)
        {
            AnaliseEntidade Analise = new AnaliseRepositorio().ObterUmPorCodigo(Id);
            if (Analise == null)
            {
                return 0;
            }
            return new AnaliseRepositorio().Excluir(Analise);
        }
    }
}
