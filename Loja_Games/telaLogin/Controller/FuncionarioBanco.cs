using System.Windows.Forms;
using LojaGames.Classes;
using LojaGames.Model.DAO;

namespace LojaGames.Controller
{
    class FuncionarioBanco
    {
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

        public void RemoverFuncionario(long removeCpf)
        {
            //Banco.dicFunc.Remove(removeCpf);
        }

        public void BuscarDadosFuncionario()
        {
            
        }

        public void ExibirTodosFuncionario(DataGridView dataGrid)
        {
            //metodo para exibir todos do banco
            FuncionarioDAO funcionarioDao = new FuncionarioDAO();
            dataGrid.DataSource = funcionarioDao.ListAllFuncionarios();
            


        }

    }
}
