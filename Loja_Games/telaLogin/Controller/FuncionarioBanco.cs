using System.Collections.Generic;
using LojaGames.Classes;
using LojaGames.Model;

namespace LojaGames.Controller
{
    class FuncionarioBanco
    {
        //Declaração dos métodos de controle

        //recebe um objeto do tipo cliente e add ele na lista estático dentro da classe Banco (Model)
        public void SalvarFuncionario(Funcionario f)
        {
            if (Banco.dicFunc.ContainsKey(f.CPF))
                Banco.dicFunc[f.CPF] = f;
            else
                Banco.dicFunc.Add(f.CPF, f);
        }

        public void RemoverFuncionario(long removeCpf)
        {
            Banco.dicFunc.Remove(removeCpf);
        }

        public void BuscarDadosFuncionario()
        {
            
        }

        public void ExibirTodosFuncionario()
        {
            
            //metodo para exibir todos do banco
        }

    }
}
