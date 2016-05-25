using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Model
{
    class Pessoa
    {
        //Declaração das variáveis
        private string nome;
        private long cpf;
        private string rg;
        private DateTime dataNascimento;
        private string telefone;
        private string sexo;
        private string estadoCivil;
        private string email;
        private string rua;
        private string numero;
        private string bairro;
        private string estado;
        private string cep;
        private string cidade;

        //Declaração das Propriedades
        public string Nome { get; set; }
        public long CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value >= 0 ? value : 0;
            }
        }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public string Email { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
    }
}
