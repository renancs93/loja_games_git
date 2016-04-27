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
    public partial class telaCadastroFuncionario : Form
    {
        private telaPrincipal telaP = null;

        public telaCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
            telaP.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //realizar as verificações dos campos antes de cadastrar


            MessageBox.Show("Funcionário cadastrado com sucesso!");
            Close();
            telaP.Show();
        }

        public void getTelaPrincipal(telaPrincipal t)
        {
            telaP = t;
        }

        private void telaCadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {

            Dispose();
            telaP.Show();
        }
    }
}
