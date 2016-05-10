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
        private int codigo;
        private Cliente cliente;
        private Jogos jogos;
        private Funcionario funcionario;
        private int quantidade;
        private Pagamento pagamento;
        private int numeroParcelas;
        private float valorParcelas;
        private float total;
        

        //Declaração das Propriedades
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value >= 0 ? value : 0;
            }
        }

        public Cliente Cliente { get; set; }
        public Jogos Jogos { get; set; }
        public Funcionario Funcionario { get; set; }

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

        public string Pagamento { get; set; }

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

        //Declaração dos métodos
        public void AdicionarVenda()
        {

        }

        public void RemoverVenda()
        {

        }

        public void EditarDadosVenda()
        {

        }
    }
}
