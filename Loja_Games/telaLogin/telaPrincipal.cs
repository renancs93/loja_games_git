using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

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
                //jogos.MdiParent = this;            
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
            login.setTelaPrincipal(this, btnLogarUsuario);
            login.setBotoes(btnJogos, btnCadastroCliente, btnVenda, btnCadastrarFuncionario);
            Hide(); //esconde a telaPrincipal
            login.ShowDialog();
            
        }
        
        private void telaPrincipal_Load(object sender, EventArgs e)
        {
 

        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            telaCadastroCliente cadCliente = new telaCadastroCliente();
            cadCliente.setTelaPrincipal(this);//chama o metodo dentro da telaCadastroCliente passado essa tela como referencia
            cadCliente.Show();
            Hide();

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

        private void btnVenda_Click(object sender, EventArgs e)
        {
            telaVenda venda = new telaVenda();
            venda.getTelaPrincipal(this);//cahama o metodo dentro da tela venda passado a Tela Principal
            venda.Show();

            Hide();
        }

        private void btnVenda_MouseEnter(object sender, EventArgs e)
        {
            btnVenda.ForeColor = Color.Blue;
        }

        private void btnVenda_MouseLeave(object sender, EventArgs e)
        {
            btnVenda.ForeColor = Color.Red;
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            telaCadastroFuncionario novoFunc = new telaCadastroFuncionario();
            novoFunc.getTelaPrincipal(this);
            novoFunc.Show();
            Hide();

        }

        private void btnCadastrarFuncionario_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrarFuncionario.ForeColor = Color.Blue;
        }

        private void btnCadastrarFuncionario_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrarFuncionario.ForeColor = Color.Red;
        }
    }
}
