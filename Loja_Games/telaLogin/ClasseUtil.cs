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

        //limpa Campos
        public static void LimparCampos(Control.ControlCollection tela)
        {
            
            foreach(Control campo in tela)
            {
                if (campo.HasChildren)
                {
                    LimparCampos(campo.Controls);
                }

                if (campo.GetType() == typeof(TextBox))
                {
                    ((TextBox)campo).Text = string.Empty;
                }
                else if (campo.GetType() == typeof(RadioButton))
                {
                    ((RadioButton)campo).Checked = false;
                }
                else if (campo.GetType() == typeof(MaskedTextBox))
                {
                    ((MaskedTextBox)campo).Text = string.Empty;
                }
                else if(campo.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)campo).Checked = false;
                }
                else if(campo.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)campo).SelectedItem = -1;
                }


            }
            
        }

        //validas diversos campos das telas de acordo com o tipo
        public static string ValidaCampos(Control.ControlCollection componentes)
        {
            string mensagem = "";

            Control[] a = new Control[componentes.Count];

            componentes.CopyTo(a, 0);

            List<Control> controles = a.OrderBy(x => x.TabIndex).ToList();            

            foreach (Control controle in controles)
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
                

            }

            
            return mensagem;
        }

        //metodo usado para fazer o campo aceitar apenas numeros 
        public static void somenteValores(TextBox campo, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!campo.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }




    //fim da classe útil
    }
}
