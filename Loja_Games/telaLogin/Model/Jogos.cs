using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Classes
{
    class Jogos
    {
        //Declaração das Variáveis
        private int codigo;

        private string nome;
        private float preco;
        private string console;
        private string genero;
        private int qntEstoque;


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

        public string Nome { get; set; }
        
        public float Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value >= 0 ? value : 0;
            }
        }

        public string Console { get; set; }
        public string Genero { get; set; }
        
        public int QntEstoque
        {
            get
            {
                return qntEstoque;
            }
            set
            {
                qntEstoque = value >= 0 ? value : 0;
            }
        }

        //Declaração dos métodos
        public void AdicionarJogos()
        {

        }

        public void RemoverJogos()
        {

        }

        public void EditarDadosJogos()
        {

        }
    }
}
