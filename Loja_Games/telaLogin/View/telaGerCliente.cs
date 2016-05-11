using System.Windows.Forms;

namespace LojaGames.View
{
    public partial class telaGerCliente : Form
    {
        private Form telaP = null;

        public telaGerCliente()
        {
            InitializeComponent();
        }

        public void setTelaAnterior(Form t)
        {
            telaP = t;
        }

        private void telaGerCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }
    }
}
