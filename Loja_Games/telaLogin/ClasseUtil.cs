using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaGames
{
    public static class ClasseUtil
    {
        //soma dois numeros inteiros
        public static int SumInteiros(int n1, int n2)
        {
            return n1 + n2;
        }

        public static bool CampoVazio(TextBox campo)
        {
            bool retorno = false;
            if (string.IsNullOrEmpty(campo.Text))
            {                
                retorno = true;
            }
            return retorno;
        }

        public static string ValidaCampos(Control.ControlCollection componentes)
        {
            string mensagem = "";

            foreach(Control controle in componentes)
            {
                if (controle.HasChildren)
                {
                    mensagem += ValidaCampos(controle.Controls);

                }

                if (controle.GetType() == typeof(TextBox))
                {
                    bool r = CampoVazio((TextBox)controle);
                    
                    if(r)
                    {
                        // escrever a mensagem
                        String nomeDoCampo = ((TextBox)controle).Name.Remove(0, 3);
                        mensagem = mensagem + string.Format("\nO campo {0} deve ser preenchido!", nomeDoCampo);
                    }
                }
            }

            return mensagem;
        }





    }
}
