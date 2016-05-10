using System;
using System.Linq;
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
            DialogResult sair = MessageBox.Show("Os dados serão perdidos! \n Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(sair == DialogResult.Yes)
            {
                Close();
                telaP.Show();
            }
            
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

        private void txtCodVendaAluga_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtCodVendaAluga.Text.Contains(','))
                    {
                        e.KeyChar = (Char)0;
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void btnGerarRelatorio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Relatório Gerado");

        }
    }
}
