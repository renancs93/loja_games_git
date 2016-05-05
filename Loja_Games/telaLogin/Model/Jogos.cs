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
        private int qnt_estoque;


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
        
        public int Qnt_Estoque
        {
            get
            {
                return qnt_estoque;
            }
            set
            {
                qnt_estoque = value >= 0 ? value : 0;
            }
        }
    }
}
