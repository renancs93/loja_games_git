using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using LojaGames.View;

namespace LojaGames
{
    public partial class telaPrincipal : System.Windows.Forms.Form
    {
        
        public telaPrincipal()
        {
            InitializeComponent();

        }

        private void CarregamentoBarraProgresso()
        {
            barraProgresso.Value = 0;

            int tempoCarregamento = 25; //tempo (milissegundo) do sleep ao clicar nos botões de telas

            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(tempoCarregamento);
                barraProgresso.Value = barraProgresso.Value + 1;
            }

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.setTelaAnterior(this);
            Hide(); //esconde a telaPrincipal
            login.Show();
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            //irá desabilitar a visibilidade dos botões da tela principal
            habilitarBotoes(false);
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            CarregamentoBarraProgresso(); //chama o metodo que carrega a barra de progresso

            telaJogos jogos = new telaJogos();
            //jogos.MdiParent = this;
            jogos.setTelaAnterior(this);
            Hide();
            jogos.Show();
            
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            CarregamentoBarraProgresso();

            telaVenda venda = new telaVenda();
            venda.setTelaPrincipal(this);//chama o metodo dentro da tela venda passando a Tela Principal
            venda.Show();
            Hide();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            CarregamentoBarraProgresso();

            telaRelatorios telaRelatorios = new telaRelatorios();
            telaRelatorios.setTelaAnterior(this);
            Hide();
            telaRelatorios.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult SairApp = MessageBox.Show("Deseja realmente Sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (SairApp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            CarregamentoBarraProgresso();

            telaGerCliente clientes = new telaGerCliente();
            clientes.setTelaAnterior(this);
            clientes.Show();
            Hide();

        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            CarregamentoBarraProgresso();

            telaGerFuncionario funcionario = new telaGerFuncionario();
            funcionario.setTelaAnterior(this);
            funcionario.Show();
            Hide();
            
        }


        private void btnJogos_MouseEnter(object sender, EventArgs e)
        {
            btnJogos.ForeColor =  Color.Blue;
        }

        private void btnJogos_MouseLeave(object sender, EventArgs e)
        {
            btnJogos.ForeColor = Color.Red;
        }

        private void btnSair_MouseEnter(object sender, EventArgs e)
        {
              btnSair.ForeColor = Color.Yellow;   
        }

        private void btnSair_MouseLeave(object sender, EventArgs e)
        {
           btnSair.ForeColor = Color.Silver;
        }

        private void btnVenda_MouseEnter(object sender, EventArgs e)
        {
            btnVenda.ForeColor = Color.Blue;
        }

        private void btnVenda_MouseLeave(object sender, EventArgs e)
        {
            btnVenda.ForeColor = Color.Red;
        }

        private void telaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnRelatorios_MouseEnter(object sender, EventArgs e)
        {
            btnRelatorios.ForeColor = Color.Blue;
        }

        private void btnRelatorios_MouseLeave(object sender, EventArgs e)
        {
            btnRelatorios.ForeColor = Color.Red;
        }

        private void btnClientes_MouseEnter(object sender, EventArgs e)
        {
            btnClientes.ForeColor = Color.Blue;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
            btnClientes.ForeColor = Color.Red;
        }

        private void btnFuncionarios_MouseEnter(object sender, EventArgs e)
        {
            btnFuncionarios.ForeColor = Color.Blue;
        }

        private void btnFuncionarios_MouseLeave(object sender, EventArgs e)
        {
            btnFuncionarios.ForeColor = Color.Red;
        }

        public void habilitarBotoes(bool ativarBotoes)
        {
            btnJogos.Visible = ativarBotoes;
            btnVenda.Visible = ativarBotoes;
            btnClientes.Visible = ativarBotoes;
            btnFuncionarios.Visible = ativarBotoes;

            //habilitar botões para determinado tipo de login (pendente implantar)
            btnRelatorios.Visible = ativarBotoes;

            if (ativarBotoes == true)
            {
                btnLogarUsuario.BackColor = Color.Green;
                btnLogarUsuario.Enabled = false;
                btnLogoff.Enabled = ativarBotoes;
            }
            else
            {
                btnLogarUsuario.Enabled = true;
                btnLogarUsuario.BackColor = Color.Gold;
                btnLogoff.Enabled = ativarBotoes;
            }
        }







        //final da tela principal
    }
}
