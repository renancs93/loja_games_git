using LojaGames.Model;
using LojaGames.Model.DAO;
using System.Data;
using LojaGames.Classes;

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

        public void AtualizarPessoa(long cpf, Funcionario f)
        {
            PessoaDao.Update(cpf, f);
        }

        public void RemoverPessoa(long removeCpf)
        {
            PessoaDao.Delete(removeCpf);
        }

    }
}
