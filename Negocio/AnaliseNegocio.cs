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

        public List<AnaliseObterTodosDTO> ObterListaPorSolicitanteNome(string nome)
        {
            return new AnaliseRepositorio().ObterListaPorSolicitanteNome(nome);
        }

        public List<AnaliseObterTodosDTO> ObterListaPorSolicitanteCpf(string nome)
        {
            return new AnaliseRepositorio().ObterListaPorSolicitanteCpf(nome);
        }


        public int Salvar(string nomeAnalise, int idSolicitante, string Local, string Referencia, string cultura, string tipoSolicitacao, string NomeAmostra1, string NomeAmostra2, string NomeAmostra3, string NomeAmostra4)
        {
            AnaliseEntidade Analise = new AnaliseEntidade();
            Analise.NomeAnalise = nomeAnalise.Trim();
            //Analise.Solicitantes = Solicitante;
            Analise.Local = Local;
            Analise.Referencia = Referencia;
            Analise.Cultura = cultura;
            Analise.TipoSolicitacao = tipoSolicitacao;
            Analise.DataCriado = DateTime.Now;
            Analise.NomeAmostra1 = NomeAmostra1;
            Analise.NomeAmostra2 = NomeAmostra2;
            Analise.NomeAmostra3 = NomeAmostra3;
            Analise.NomeAmostra4 = NomeAmostra4;
            Analise.Completa = false;
            return new AnaliseRepositorio().Salvar(Analise, idSolicitante);
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
