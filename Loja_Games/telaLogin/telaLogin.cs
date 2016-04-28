using System;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaLogin : Form
    {
        private telaPrincipal telaP = null;//variável que declara a tela principal

        public telaLogin()
        {
            InitializeComponent();

        }

        private void telaLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCampoUsuario_Leave(object sender, EventArgs e)
        {
            //evento "Leave" do campo de texto usuário, onde verifica se o campo está vazio ao sair dele
            if(txtCampoUsuario.Text != string.Empty)
            {
                imgOK_usuario.Visible = true;
            }
            else
            {
                imgOK_usuario.Visible = false;
            }
            
        }

        private void txtCampoSenha_Leave(object sender, EventArgs e)
        {
            //evento "Leave" do campo de texto senha, onde verifica se o campo está vazio ao sair dele
            if(txtCampoSenha.Text != string.Empty)
            {
                imgOK_senha.Visible = true;
            }
            else
            {
                imgOK_senha.Visible = false;
            }

            //ativar botão "Login" caso os campos usuario e senha estiver OK
            if((imgOK_usuario.Visible && imgOK_senha.Visible) == true)
            {
                btnLogar.Enabled = true;
            }
            else
            {
                btnLogar.Enabled = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Chama a tela principal
            telaP.Show();
            Dispose();
        }

        private void telaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            //validar os campos digitados
            string user = txtCampoUsuario.Text;
            string senha = txtCampoSenha.Text;
    
            if(user == "admin" && senha == "admin")
            {
                //exibe uma mensagem com o nome do usuário
                MessageBox.Show("Bem Vindo "+ user.ToUpper());

                //chama a tela principal novamente
                telaP.Show();

                //Ativa a visibilidade dos botões da tela Principal
                telaP.habilitarBotoes(true);
                
                //necessário fechar ou esconder a tela Login ao abrir a outra
                Dispose();
            }
            else
            {
                txtObservacoes.Visible = true;
                txtObservacoes.Text = "Usuário não encontrado!";
                txtObservacoes.TextAlign = HorizontalAlignment.Center ;

                txtCampoSenha.Text = "";
                txtCampoUsuario.Text = "";
            }

            

        }

        public void setTelaPrincipal(telaPrincipal t)
        {
            telaP = t;

        }
        
       
    }
}
