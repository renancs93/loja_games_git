using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Classes
{
    class Venda
    {
        //Declaração das Variáveis
        private int codigoVenda;
        private string cpf_cliente;
        private string cpf_funcionario;
        private int codJogos;
        private int quantidade;
        private string pagamento;
        private int numeroParcelas;
        private float valorParcelas;
        private float total;
        

        //Declaração das Propriedades
        public int CodigoVenda
        {
            get
            {
                return codigoVenda;
            }
            set
            {
                codigoVenda = value >= 0 ? value : 0;
            }
        }

        public string CPF_Cliente
        {
            get
            {
                return cpf_funcionario;
            }
            set
            {
                cpf_funcionario = value;
            }
        }
        public string CPF_Funcionario { get; set; }

        public int CodJogos
        {
            get
            {
                return codJogos;
            }
            set
            {
                codJogos = value > 0 ? value : 0;
            }

        }
        

        public int Quantidade
        {
            get
            {
                return quantidade;
            }
            set
            {
                quantidade = value >= 0 ? value : 0;
            }
        }

        public string Pagamento
        {
            get
            {
                return pagamento;
            }
            set
            {
                pagamento = value;
            }
        } 

        public int NumeroParcelas
        {
            get
            {
                return numeroParcelas;
            }
            set
            {
                numeroParcelas = value >= 0 ? value : 0;
            }
        }

        public float ValorParcelas
        {
            get
            {
                return valorParcelas;
            }
            set
            {
                valorParcelas = value >= 0 ? value : 0;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value >= 0 ? value : 0;
            }
        }

    }
}
