using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaPrincipal : Form
    {
        int tempoCarregamento = 30; //tempo de sleep ao clicar nos botões de telas

        public telaPrincipal()
        {
            InitializeComponent();

        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            telaLogin login = new telaLogin();
            login.setTelaPrincipal(this);
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
            barraProgresso.Value = 0;
            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(tempoCarregamento);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
            telaJogos jogos = new telaJogos();
            //jogos.MdiParent = this;
            jogos.getTelaPrincipal(this);
            Hide();
            jogos.Show();
            
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            barraProgresso.Value = 0;
            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(tempoCarregamento);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
            telaCadastroCliente cadCliente = new telaCadastroCliente();
            cadCliente.setTelaPrincipal(this);//chama o metodo dentro da telaCadastroCliente passado essa tela como referencia
            cadCliente.Show();
            Hide();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            barraProgresso.Value = 0;
            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(tempoCarregamento);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
            telaCadastroFuncionario novoFunc = new telaCadastroFuncionario();
            novoFunc.getTelaPrincipal(this);//chama o metodo dentro da tela Cadastro Funcionario passando a Tela Principal
            Hide();
            novoFunc.Show();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            barraProgresso.Value = 0;
            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(tempoCarregamento);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
            telaVenda venda = new telaVenda();
            venda.getTelaPrincipal(this);//chama o metodo dentro da tela venda passando a Tela Principal
            venda.Show();
            Hide();
        }

        private void btnBuscaExibir_Click(object sender, EventArgs e)
        {
            barraProgresso.Value = 0;
            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(tempoCarregamento);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
            //exibição da tela BuscaExibir
            telaBuscarExibir telaBuscaExibir = new telaBuscarExibir();
            telaBuscaExibir.getTelaPrincipal(this);
            Hide();
            telaBuscaExibir.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            barraProgresso.Value = 0;
            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(tempoCarregamento);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
            telaRelatorios telaRelatorios = new telaRelatorios();
            telaRelatorios.getTelaPrincipal(this);
            Hide();
            telaRelatorios.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult SairApp = MessageBox.Show("Deseja realmente Sair?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (SairApp == DialogResult.Yes)
            {
                MessageBox.Show("O programa será fechado", "", MessageBoxButtons.OK, MessageBoxIcon.None);
                Application.Exit();
            }
            else if (SairApp == DialogResult.No)
            {
                //não faz nada apenas volta ao programa
            }
        }

        private void btnJogos_MouseEnter(object sender, EventArgs e)
        {
            btnJogos.ForeColor =  Color.Blue;
        }

        private void btnJogos_MouseLeave(object sender, EventArgs e)
        {
            btnJogos.ForeColor = Color.Red;
        }

        private void btnCadastroCliente_MouseEnter_1(object sender, EventArgs e)
        {
            btnCadastroCliente.ForeColor = Color.Blue;
        }

        private void btnCadastroCliente_MouseLeave_1(object sender, EventArgs e)
        {
            btnCadastroCliente.ForeColor = Color.Red;
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

        private void btnCadastrarFuncionario_MouseEnter(object sender, EventArgs e)
        {
            btnCadastrarFuncionario.ForeColor = Color.Blue;
        }

        private void btnCadastrarFuncionario_MouseLeave(object sender, EventArgs e)
        {
            btnCadastrarFuncionario.ForeColor = Color.Red;
        }

        private void telaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void btnBuscaExibir_MouseEnter(object sender, EventArgs e)
        {
            btnBuscaExibir.ForeColor = Color.Blue;
        }

        private void btnBuscaExibir_MouseLeave(object sender, EventArgs e)
        {
            btnBuscaExibir.ForeColor = Color.Red;
        }

        public void habilitarBotoes(bool ativarBotoes)
        {
            btnJogos.Visible = ativarBotoes;
            btnCadastroCliente.Visible = ativarBotoes;
            btnCadastrarFuncionario.Visible = ativarBotoes;
            btnVenda.Visible = ativarBotoes;
            btnBuscaExibir.Visible = ativarBotoes;

            //habilitar botões para determinado tipo de login (pendente implantar)
            btnRelatorios.Visible = ativarBotoes;

            if (ativarBotoes == true)
            {
                btnLogarUsuario.BackColor = Color.Green;
                btnLogoff.Enabled = ativarBotoes;
            }
            else
            {
                btnLogarUsuario.BackColor = Color.Gold;
                btnLogoff.Enabled = ativarBotoes;
            }
        }





        //final da tela principal
    }
}
