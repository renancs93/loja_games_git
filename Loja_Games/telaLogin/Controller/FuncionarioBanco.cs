using System.Windows.Forms;
using LojaGames.Classes;
using LojaGames.Model.DAO;

namespace LojaGames.Controller
{
    class FuncionarioBanco
    {
        FuncionarioDAO funcionarioDao = new FuncionarioDAO();

        //Declaração dos métodos de controle

        public void SalvarFuncionario(Funcionario f)
        {
            PessoaDAO pessoaDao = new PessoaDAO();
            pessoaDao.Create(f);

            FuncionarioDAO funcDao = new FuncionarioDAO();
            funcDao.Create(f);
   
        }
        
        public void AtualizarFuncionario(long cpf, Funcionario f)
        {
            funcionarioDao.Update(cpf, f);

        }

        //Metodo de busca de apenas um funcionario
        public Funcionario BuscarFuncionario(long cpf_func)
        {
            return funcionarioDao.Read(cpf_func);
        }


        public void RemoverFuncionario(long removeCpf)
        {
            funcionarioDao.Delete(removeCpf);
        }

        public void BuscarDadosFuncionario()
        {
            
        }

        public void ExibirTodosFuncionario(DataGridView dataGrid)
        {
            //metodo para exibir todos do banco
            dataGrid.DataSource = funcionarioDao.ListAllFuncionarios();
            
        }

    }
}
