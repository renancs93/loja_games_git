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

        //Verifica se um textBox está vazio
        public static bool CampoVazio(TextBox campo)
        {
            bool retorno = false;
            if (string.IsNullOrEmpty(campo.Text))
            {                
                retorno = true;
            }
            return retorno;
        }

        //verifica a Seleção de um RadioButton
        public static bool RadioSelecionado(RadioButton opcao)
        {
            bool retorno = false;

            if (opcao.Checked)
            {
                retorno = true;
            }

            return retorno;
        }

        //validas diversos campos das telas de acordo com o tipo
        public static string ValidaCampos(Control.ControlCollection componentes)
        {
            string mensagem = "";

            foreach(Control controle in componentes)
            {
                if (controle.HasChildren)
                {
                    mensagem += ValidaCampos(controle.Controls);

                }

                //Verifica os campos TextBox
                if (controle.GetType() == typeof(TextBox))
                {
                    bool r = CampoVazio((TextBox)controle);
                    
                    if(r)
                    {
                        // escrever a mensagem
                        String nomeDoCampo = ((TextBox)controle).Name.Remove(0, 3);
                        mensagem += string.Format("\nO campo {0} deve ser preenchido!", nomeDoCampo);
                    }
                }

                /*
                //Verifica os radiosButons
                if (controle.GetType() == typeof(RadioButton))
                {
                    bool r = RadioSelecionado((RadioButton)controle);
                    int cont = 0;

                    if (r)
                    {
                        cont++;
                    }

                    return cont;
                }
                */  


            }

            
            return mensagem;
        }





    }
}
