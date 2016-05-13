using System;
using System.Windows.Forms;

namespace LojaGames.View
{
    public partial class DadosLoginFuncionario : Form
    {
        private PictureBox img = null;
        public DadosLoginFuncionario(PictureBox imagemOK)
        {
            InitializeComponent();
            img = imagemOK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string senha = mtbSenha.Text;
            string confirmSenha = mtbConfirmarSenha.Text;

            if(user == string.Empty || senha == string.Empty || confirmSenha == string.Empty)
            {
                DialogResult alerta = MessageBox.Show("Todos os campos devem ser preenchidos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if(senha != confirmSenha)
            {
                MessageBox.Show("Os campos de senha não coincidem", "Atenção", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
                //acessaVariavel(true);
                img.Visible = true;
                Close();
            }
        }
    }
}
