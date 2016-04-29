using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaBuscarExibir : Form
    {
        private telaPrincipal telaP = null;

        public telaBuscarExibir()
        {
            InitializeComponent();
        }

        public void getTelaPrincipal(telaPrincipal t)
        {
            telaP = t;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            telaP.Show();
        }

        private void telaBuscarExibir_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }
    }
}
