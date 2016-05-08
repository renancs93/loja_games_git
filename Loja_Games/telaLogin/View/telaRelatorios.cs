using System;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaRelatorios : Form
    {
        private Form telaP = null;

        public telaRelatorios()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            telaP.Show();
        }

        public void setTelaAnterior(Form t)
        {
            telaP = t;
        }

        private void telaRelatorios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }

        private void mtbCpfCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas dígitos de 0 a 9 são aceitos neste campo.\n\n" +
             "Você está tentando inserir um caractere inválido ");
        }
    }
}
