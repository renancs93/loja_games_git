using LojaGames.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Classes
{
    class Funcionario : Pessoa
    {
        //public Dictionary<long, Funcionario> dicFunc = new Dictionary<long, Funcionario>();
        
        //Declaração das Variáveis
        private int codigo_funcionario;

        private string username;
        private string senha;
        private string cargo;
        private float salario_base;
        private DateTime data_inicio;

        public Funcionario()
        {
            
        }

        //Propriedades
        public int Codigo_Funcionario
        {
            get
            {
                return codigo_funcionario;
            }

            set
            {
                codigo_funcionario = value >= 0 ? value : 0;
            }
        }
        
        public string Cargo { get; set; }

        public float Salario_Base
        {
            get
            {
                return salario_base;
            }

            set
            {
                salario_base = value >= 0 ? value : 0;
            }
        }

        public DateTime Data_Inicio { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }

        /*
        //Declaração dos métodos
        public void AdicionarFuncionario(long cpfFunc, Funcionario func)
        {
            //dicFunc.Add(cpfFunc, func);
        }

        public void RemoverFuncionario()
        {

        }

        public void EditarDadosFuncionario()
        {

        }
        */

       
    }
}
