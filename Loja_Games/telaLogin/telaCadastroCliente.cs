using System;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaCadastroCliente : Form
    {
        private telaPrincipal telaPri = null;

        public telaCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Cadastrado com Sucesso!");
            telaPri.Show();
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaPri.Show();//exibi a telaPrincipal setada no metodo setTelaPrincipal desse form
            Close();//fecha esse form
        }

        public void setTelaPrincipal(telaPrincipal t)
        {
            telaPri = t;
        }
    }
}
