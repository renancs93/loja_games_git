using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
                Thread.Sleep(20);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
                telaJogos jogos = new telaJogos();
                jogos.Show();
            
        }

        private void btnJogos_MouseEnter(object sender, EventArgs e)
        {
           
            btnJogos.ForeColor =  Color.Yellow;
            //btnJogos.ForeColor = Color.Red;
        }

        private void btnJogos_MouseLeave(object sender, EventArgs e)
        {
            btnJogos.ForeColor = Color.Red;
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            Hide();
           
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
            btnCadastroCliente.ForeColor = Color.Yellow;
        }

        private void btnCadastroCliente_MouseLeave_1(object sender, EventArgs e)
        {
            btnCadastroCliente.ForeColor = Color.Red;
        }
    }
}
