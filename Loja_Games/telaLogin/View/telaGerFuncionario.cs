using System.Collections.Generic;
using System.Windows.Forms;
using LojaGames.Classes;
using LojaGames.Controller;
using LojaGames.Model;

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
                /*instancio a classe(controller) FuncionariBanco para poder usar o metodo dessa classe
                * chamo esse metodo passando como parametro o objeto retornado do metodo da tela populaNovoFuncionario  
                */
                FuncionarioBanco funcionarioBanco = new FuncionarioBanco();
                funcionarioBanco.SalvarFuncionario(popularNovoFuncionario());

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

        private Funcionario popularNovoFuncionario()
        {
            Funcionario f = new Funcionario();

            f.CPF = long.Parse(mtbCPF.Text);
            f.Nome = txtNome.Text;

            return f;
        }

       
        private void btnExibirTodosFunc_Click(object sender, System.EventArgs e)
        {
            dgvExibeFuncionarios.Rows.Clear(); //limpa o datagrid
            foreach(KeyValuePair<long, Funcionario> linha in Banco.dicFunc)
            {
                dgvExibeFuncionarios.Rows.Add(linha);

            }


            //dgvExibeFuncionarios.DataSource = Banco.dicFunc;
        }

        private void btnSairExibi_Click(object sender, System.EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente sair? ", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Close();
                telaP.Show();
            }
        }
    }
}
