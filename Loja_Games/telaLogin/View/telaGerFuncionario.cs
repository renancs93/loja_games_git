using System.Windows.Forms;
using LojaGames.Classes;

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
            DadosLoginFuncionario telaLoginSenha = new DadosLoginFuncionario(imgUserSenhaOK);
            imgUserSenhaOK.Visible = false;
            telaLoginSenha.Show();
        }

        private void btnCadastrarFuncionario_Click(object sender, System.EventArgs e)
        {
            //realizar as verificações dos campos antes de cadastrar
            string MensagemErro = "";

            //MensagemErro = ClasseUtil.ValidaCampos(abaCadFuncionario.Controls);

            if (MensagemErro == "")
            {
                Funcionario func = CadastrarFuncionario();
                func.AdicionarFuncionario(func.CPF, func);
                dgvExibeFuncionarios.Rows.Add(func.CPF,func.Nome);

                DialogResult cadastrado = MessageBox.Show("Funcionário cadastrado com sucesso.", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.None);
                //Close();
                //telaP.Show();
            }
            else
            {
                DialogResult alerta = MessageBox.Show(MensagemErro, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Os dados serão perdidos! \n Deseja mesmo sair da tela de cadastro? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cancel == DialogResult.Yes)
            {
                Close();
                telaP.Show();
            }
        }

        //metodo para cadastrar funcionario
        private Funcionario CadastrarFuncionario()
        {
            Funcionario f = new Funcionario();
            f.CPF = long.Parse(mtbCPF.Text);
            f.Nome = txtNome.Text;
            return f;
        }

        private void btnExibirTodosFunc_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
