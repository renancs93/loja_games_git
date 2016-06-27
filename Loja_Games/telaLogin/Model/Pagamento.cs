using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Classes
{
    class Pagamento
    {
        private int codigo_pagamento;
        private string tipo;

        public int Codigo_pagamento
        {
            get
            {
                return codigo_pagamento;
            }

            set
            {
                codigo_pagamento = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        //Declaração das Variáveis       
        public enum tipoPagamento
        {
            Dinheiro = 1,
            Cheque = 2,
            Debito = 3,
            Credito = 4,
            Boleto = 5
        }
        

    }
}
