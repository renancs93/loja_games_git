using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames
{
    class Cliente
    {
        private int codigo_cliente;

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

        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime Data { get; set; }
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
        public string CEP { get; set; }
        public string Cidade { get; set; }
    }
}
