using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Classes
{
    class Funcionario
    {
        //Declaração das Variáveis
        private int codigo_funcionario;

        private string nome;
        private string cpf;
        private string rg; 
        private DateTime data_nascimento; 
        private string telefone; 
        private string sexo;
        private string status;
        private string email;
        private string rua;
        private int numero;
        private string bairro;
        private string estado;
        private string cep; 
        private string cidade;
        private string cargo;
        private float salario_base;
        private DateTime data_inicio;

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
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        
        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value >= 0 ? value : 0;
            }
        }

        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
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
    }
}
