using System;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaVenda : Form
    {
        private telaPrincipal telaP = null;

        public telaVenda()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {

        }

        private void gbpDadoVenda_Enter(object sender, EventArgs e)
        {

        }

        public void getTelaPrincipal(telaPrincipal t)
        {
            telaP = t;
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            telaP.Show(); //exibe a tela Principal
            Close(); //fecha a telaVenda
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Compra realizada com Sucesso");

            telaP.Show();
            Close();
        }

        private void telaVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaP.Show();
        }
    }
}
