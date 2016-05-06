using System;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaCadastroCliente : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form telaP = null;

        public telaCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string MensagemErro = "";

            MensagemErro = ClasseUtil.ValidaCampos(Controls);
            
            if(MensagemErro == "")
            {
                MessageBox.Show("Cliente Cadastrado com Sucesso!");
                telaP.Show();
                Close();
            }
            else
            {
                MessageBox.Show(MensagemErro);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Os dados serão perdidos!\nDeseja realmente Sair?", "Sair" ,MessageBoxButtons.YesNo ,MessageBoxIcon.Question);

            
            if(sair == DialogResult.Yes)
            {
                telaP.Show();//exibi a telaPrincipal setada no metodo setTelaPrincipal desse form
                Close();//fecha esse form
            }
            

        }

        public void setTelaAnterior(System.Windows.Forms.Form t)
        {
            telaP = t;
        }

        private void telaCadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }
    }
}
