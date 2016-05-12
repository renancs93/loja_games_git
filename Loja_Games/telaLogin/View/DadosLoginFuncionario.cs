using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaGames.View
{
    public partial class DadosLoginFuncionario : Form
    {
        public DadosLoginFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(mtbConfirmarSenha.Text == "" || txtUsuario.Text == "" || mtbSenha.Text == "")
            {
                DialogResult alerta = MessageBox.Show("Todos os campos devem ser preenchidos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
                Close();
            }
        }
    }
}
