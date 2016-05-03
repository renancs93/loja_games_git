using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames
{
    public static class ClasseUtil
    {
        //soma dois numeros inteiros
        public static int SumInteiros(int n1, int n2)
        {
            return n1 + n2;
        }

        public static bool CampoVazio(System.Windows.Forms.TextBox campo)
        {
            if (string.IsNullOrEmpty(campo.Text))
            {                
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ValidaIdade()
        {
            
        }





    }
}
