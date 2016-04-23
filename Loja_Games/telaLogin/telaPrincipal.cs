using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Loja_games;

namespace LojaGames
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();

        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            barraProgresso.Value = 0;
            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(40);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
                telaJogos jogos = new telaJogos();
                jogos.Show();
            
        }

        private void btnJogos_MouseEnter(object sender, EventArgs e)
        {
            btnJogos.ForeColor =  Color.Blue;
        }

        private void btnJogos_MouseLeave(object sender, EventArgs e)
        {
            btnJogos.ForeColor = Color.Red;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.ShowDialog();
            
            //Hide();//esconde a telaPrincipal

        }
        
        private void telaPrincipal_Load(object sender, EventArgs e)
        {

            

        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            telaCadastroCliente cliente = new telaCadastroCliente();
            cliente.Show();
        }

        private void btnCadastroCliente_MouseEnter_1(object sender, EventArgs e)
        {
            btnCadastroCliente.ForeColor = Color.Blue;
        }

        private void btnCadastroCliente_MouseLeave_1(object sender, EventArgs e)
        {
            btnCadastroCliente.ForeColor = Color.Red;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.Yellow;
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
            btnSair.ForeColor = Color.Silver;
        }
    }
}
