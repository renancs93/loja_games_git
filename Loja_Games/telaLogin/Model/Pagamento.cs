using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Classes
{
    class Pagamento
    {
        private int codigo;
        private string tipo;

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
    }
}
