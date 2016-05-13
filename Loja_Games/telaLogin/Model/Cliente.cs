using LojaGames.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames
{
    class Cliente : Pessoa
    {
        //Declaração das Variáveis
        private int codigo_cliente;

        //Propriedades
        public int Codigo_Cliente
        {
            get
            {
                return codigo_cliente;
            }

            set
            {
                codigo_cliente = value >= 0 ? value : 0;
            }
        }
        

        //Declaração dos métodos
        public void AdicionarCliente()
        {
            
                
        }

        public void RemoverCliente()
        {

        }

        public void EditarDadosCliente()
        {

        }
    }
}
