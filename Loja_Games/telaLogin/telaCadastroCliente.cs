using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_games
{
    public partial class telaCadastroCliente : Form
    {
        public telaCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliente Cadastrado com Sucesso!");
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void telaCadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
