using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Classes
{
    class Pagamento
    {
        //Declaração das Variáveis
        private int codigo;
        private string tipo;

        //Declaração das Propriedades
        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value > 0? value : 0;
            }
        }

        public string Tipo { get; set; }
        
    }
}
