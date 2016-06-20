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

            /*
            if (Banco.dicFunc.ContainsKey(f.CPF))
                Banco.dicFunc[f.CPF] = f;
            else
                Banco.dicFunc.Add(f.CPF, f);
            */        
        }
        
        public void AtualizarFuncionario(long cpf_func, Funcionario f)
        {
            funcionarioDao.Update(cpf_func, f);
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
