using System.Collections.Generic;
using System.Data;
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

        public void ExibirTodosFuncionario(DataGridView dataGrid)
        {
            //metodo para exibir todos do banco
            
            dataGrid.DataSource = funcionarioDao.ListAllFuncionarios();   
        }


        public DataTable BuscarFuncionario_nome(string nome)
        {
            return funcionarioDao.BuscaFunc_nome(nome);
        }

        public DataTable BuscarFuncionario_cpf(string cpf)
        {
            return funcionarioDao.BuscaFunc_cpf(cpf);
        }

        public string BuscarFuncionario_codigo(int cod)
        {
            return funcionarioDao.BuscarFunc_cod(cod);
        }

        public long BuscarFuncionario_codigo_retornaCPF(int cod)
        {
            return funcionarioDao.BuscarFunc_PorCod_retCPF(cod);
        }

        public int gerar_codigoFunc()
        {
            return funcionarioDao.prox_cod_funcionario();
        }

    }
}
