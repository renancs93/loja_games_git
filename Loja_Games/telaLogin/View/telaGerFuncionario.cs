using System.Windows.Forms;

namespace LojaGames.View
{
    public partial class telaGerFuncionario : Form
    {
        private Form telaP = null;

        public telaGerFuncionario()
        {
            InitializeComponent();
        }

        public void setTelaAnterior(Form t)
        {
            telaP = t;
        }

        private void telaGerFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();

        }

        private void btnCadastro_Click(object sender, System.EventArgs e)
        {
            DadosLoginFuncionario telaLoginSenha = new DadosLoginFuncionario();
            telaLoginSenha.Show();
        }
    }
}
