using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaGames.Classes;

namespace LojaGames.Model
{
    class Aluguel
    {
        //Declaração das variáveis
        private int codigoAluguel;
        private string cpf_cliente;
        private string cpf_funcionario;
        private int codigoJogo;
        private string pagamento;
        private int dias;
        private float valorTotal;

        //Declaração das propriedades
        public int CodigoAluguel
        {
            get
            {
                return codigoAluguel;
            }
            set
            {
                codigoAluguel = value >= 0 ? value : 0;
            }
        }
        public string CPF_Cliente { get; set; }
        public string CPF_Funcionario { get; set; }
        
        public int CodigoJogo
        {
            get
            {
                return codigoJogo;
            }
            set
            {
                CodigoJogo = value > 0 ? value : 0;
            }
        }
        public string Pagamento { get; set; }

        
        public int Dias
        {
            get
            {
                return dias;
            }
            set
            {
                dias = value >= 0 ? value : 0;
            }
        }
        
        public float ValorTotal
        {
            get
            {
                return valorTotal;
            }
            set
            {
                valorTotal = value >= 0 ? value : 0;
            }
        }

        //Declaração dos métodos
        public void AdicionaAluguel()
        {

        }

        public void RemoveAluguel()
        {

        }

        public void EditarAluguel()
        {

        }

    }
}
