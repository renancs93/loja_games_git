using System;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaCadastroCliente : Form
    {
        private telaPrincipal telaP = null;

        public telaCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            

            string MensagemErro = ClasseUtil.ValidaCampos(this.Controls);
            
            MessageBox.Show(MensagemErro);


            MessageBox.Show("Cliente Cadastrado com Sucesso!");
            telaP.Show();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaP.Show();//exibi a telaPrincipal setada no metodo setTelaPrincipal desse form
            Close();//fecha esse form
        }

        public void setTelaPrincipal(telaPrincipal t)
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
