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
    public partial class telaLogin : Form
    {
        
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
            telaPrincipal cancel =  new telaPrincipal();
            cancel.Visible = true; //ativa a visibilidade da telaPrincipal

            Dispose();

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            //necessário fechar ou esconder a tela Login ao abrir a outra
            Dispose();

            //exibe a tela principal
            telaPrincipal telaPri = new telaPrincipal();
            telaPri.Visible = true;
            
        }
    }
}
