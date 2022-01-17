using Entidade;
using Entidade.DTO;
using Repositorio;
using System.Collections.Generic;

namespace Negocio
{
    public class FazendaNegocio
    {
        public List<FazendaDTO> ObterTodos(int idProprietario)
        {
            return new FazendaRepositorio().ObterTodos(idProprietario, false);
        }

        public List<FazendaEntidade> ObterUmPorCodigoDeProprietario(int idProprietario)
        {
            return new FazendaRepositorio().ObterUmPorCodigoDeProprietario(idProprietario);
        }

        public List<FazendaDTO> ObterListaPorNome(int idProprietario, string nome)
        {
            return new FazendaRepositorio().ObterListaPorNome(idProprietario, nome, false);
        }

        public int Salvar(string fazenda, string municipio, int idProprietario)
        {
            ProprietarioEntidade proprietario = new ProprietarioNegocio().ObterUmPorCodigo(idProprietario);
            FazendaEntidade newFazenda = new FazendaEntidade();
            newFazenda.Fazenda = fazenda.Trim();
            newFazenda.Municipio = municipio.Trim();
            newFazenda.Proprietarios = proprietario;
            newFazenda.Excluido = false;
            return new FazendaRepositorio().Salvar(newFazenda);
        }

        public int Editar(int id, string fazenda, string municipio, int idProprietario)
        {
            ProprietarioEntidade proprietario = new ProprietarioNegocio().ObterUmPorCodigo(idProprietario);
            if (proprietario == null)
            {
                return 0;
            }

            FazendaEntidade newFazenda = new FazendaRepositorio().ObterUmPorCodigo(id);
            if (newFazenda == null)
            {
                return 0;
            }
            newFazenda.Fazenda = fazenda;
            newFazenda.Municipio = municipio;
            newFazenda.Proprietarios = proprietario;
            newFazenda.Excluido = false;
            return new FazendaRepositorio().Editar(newFazenda);
        }

        public int ExcluirLogicamente(int id, bool excluido)
        {
            FazendaEntidade fazenda = new FazendaRepositorio().ObterUmPorCodigo(id);
            if (fazenda == null)
            {
                return 0;
            }
            fazenda.Excluido = true;
            return new FazendaRepositorio().Editar(fazenda);
        }
    }
}
