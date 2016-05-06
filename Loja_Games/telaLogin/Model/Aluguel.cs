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
        private Cliente cliente;
        private Funcionario funcionario;
        private Jogos jogos;
        private int dias;
        private string formaPagamento;
        private int numeroParcelas;
        private float totalCompra;

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
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Jogos Jogos { get; set; }

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
        public string FormaPagamento { get; set; }
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

        public float TotalCompra
        {
            get
            {
                return totalCompra;
            }
            set
            {
                totalCompra = value >= 0 ? value : 0;
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
