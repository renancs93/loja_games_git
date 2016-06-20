using LojaGames.Model;
using LojaGames.Model.DAO;
using System.Data;

namespace LojaGames.Controller
{
    class PessoaBanco
    {
        PessoaDAO PessoaDao = new PessoaDAO();

        //Metodo de busca de apenas uma Pessoa
        public Pessoa BuscarPessoa(long cpf_func)
        {
            return PessoaDao.Read(cpf_func);
        }

    }
}
