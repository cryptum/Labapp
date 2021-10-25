﻿using Entidade;
using Entidade.DTO;
using Repositorio;
using System;
using System.Collections.Generic;

namespace Negocio
{
    public class AnaliseNegocio
    {
        public AnaliseNegocio() { }

        public List<AnaliseObterTodosDTO> ObterTodos()
        {
            return new AnaliseRepositorio().ObterTodos();
        }

        public AnaliseEntidade ObterUmPorCodigo(int id)
        {
            return new AnaliseRepositorio().ObterUmPorCodigo(id);
        }

        public List<AnaliseObterTodosDTO> ObterListaPorSolicitante(string nome)
        {
            return new AnaliseRepositorio().ObterListaPorSolicitante(nome);
        }


        public int Salvar(SolicitanteEntidade Solicitante, string Local, string Referencia, string cultura, string tipoSolicitacao)
        {
            AnaliseEntidade Analise = new AnaliseEntidade();
            Analise.Solicitantes = Solicitante;
            Analise.Local = Local;
            Analise.Referencia = Referencia;
            Analise.Cultura = cultura;
            Analise.TipoSolicitacao = tipoSolicitacao;
            Analise.DataCriado = DateTime.Now;
            return new AnaliseRepositorio().Salvar(Analise);
        }

        public int Editar(int Id, SolicitanteEntidade Solicitante, string Local, string Referencia, string cultura, string tipoSolicitacao)
        {
            AnaliseEntidade Analise = new AnaliseRepositorio().ObterUmPorCodigo(Id);
            if (Analise == null)
            {
                return 0;
            }
            Analise.Solicitantes = Solicitante;
            Analise.Local = Local;
            Analise.Referencia = Referencia;
            Analise.Cultura = cultura;
            Analise.TipoSolicitacao = tipoSolicitacao;
            Analise.DataUltimaAtualizacao = DateTime.Now;
            return new AnaliseRepositorio().Editar(Analise);
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
