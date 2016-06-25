using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LojaGames.Classes;
using LojaGames.Controller;

namespace LojaGames
{
    public partial class telaVenda : Form
    {
        private Form telaP = null;

        public telaVenda()
        {
            InitializeComponent();
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            //Este metodo add os item de compra no dataView

            if(txtConfirmaNomeProduto.Text != "Nome do Jogo" || txtConfirmaNomeProduto.Text != "Jogo não encontrado")
            {
                int codigo = Convert.ToInt32(txtCodProdVenda.Text);

                VendaBanco jogo = new VendaBanco();
                List<Jogos> item = jogo.AddItem_ListaVenda(codigo);
                
                int quantidade = Convert.ToInt32(numQuantidade.Value);
                float valor_total_item = (item[0].Preco) * (quantidade);

                
                dgvProdutosVenda.Rows.Add(item[0].Codigo.ToString(), item[0].Nome.ToString(), item[0].Preco.ToString(), quantidade, valor_total_item);

                //MessageBox.Show("Produto adicionado na lista!", "Venda");
                txtCodProdVenda.Text = string.Empty;
                numQuantidade.Value = 0;
            }
            else
            {
                MessageBox.Show("Dados Inválidos, tente novamente!", "Venda");
                txtCodProdVenda.Text = string.Empty;
                numQuantidade.Value = 0;
            }


        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            //Esse botão terá que remover um item da lista de compra do cliente

            DialogResult RmItem = MessageBox.Show("Deseja realmente remover o item?", "Venda", MessageBoxButtons.YesNo);

            if (RmItem == DialogResult.Yes)
            {
                MessageBox.Show("Item Removido!");
                txtCodProdVenda.Text = string.Empty;
                numQuantidade.Value = 0;
            }


        }

        //Metodo para a TelaPrincipal
        public void setTelaPrincipal(Form t)
        {
            telaP = t;
        }
        
        //evento ao clicar no X da tela
        private void telaVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Os dados serão Perdidos!\nDeseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Sair == DialogResult.Yes)
            {
                Close();
                telaP.Show();
            }

            
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            DialogResult FecharCompra = MessageBox.Show("Deseja realmente finalizar a venda?", "Finalizar Compra", MessageBoxButtons.YesNo);

            if(FecharCompra == DialogResult.Yes)
            {
                //codigo que verifica a venda e faz a baixa do estoque


                MessageBox.Show("Compra realizada com sucesso!");
                Close();
                telaP.Show();
            }


        }

        private void txtProdAlug_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancAlug_Click(object sender, EventArgs e)
        {
            DialogResult Sair = MessageBox.Show("Os dados serão Perdidos!\nDeseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(Sair == DialogResult.Yes)
            {
                Close();
                telaP.Show();
            }
            
        }

        private void btnFinAlug_Click(object sender, EventArgs e)
        {
            DialogResult FecharAluguel = MessageBox.Show("Deseja realmente finalizar o aluguel?", "Finalizar Aluguel", MessageBoxButtons.YesNo);

            if (FecharAluguel == DialogResult.Yes)
            {
                //codigo de verificação


                MessageBox.Show("Aluguel realizado com sucesso!");
                Close();
                telaP.Show();
            }
        }

        private void btnAddAlug_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Produto adicionado na lista!", "Aluguel");
            txtCodProdAluga.Text = string.Empty;
            numDiasAlug.Value = 0;

        }

        private void btnRemAlug_Click(object sender, EventArgs e)
        {
            DialogResult RmItem = MessageBox.Show("Deseja realmente remover o item?", "Aluguel", MessageBoxButtons.YesNo);

            if (RmItem == DialogResult.Yes)
            {
                MessageBox.Show("Item Removido!");
                txtCodProdAluga.Text = string.Empty;
                numDiasAlug.Value = 0;
            }

        }

        private void mtbCPFVenda_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas dígitos de 0 a 9 são aceitos neste campo.\n\n" +
             "Você está tentando inserir um caractere inválido ");
        }

        private void mtbCPFAluguel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas dígitos de 0 a 9 são aceitos neste campo.\n\n" +
             "Você está tentando inserir um caractere inválido ");
        }

        private void txtCodFuncVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseUtil.apenasNumeros(txtCodFuncVenda, e);
        }

        private void txtCodProdVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseUtil.apenasNumeros(txtCodProdVenda, e);
        }

        private void txtCodFuncAluga_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseUtil.apenasNumeros(txtCodFuncAluga, e);
        }

        private void txtCodProdAluga_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseUtil.apenasNumeros(txtCodProdAluga, e);
        }

        private void mtbCPFVenda_Leave(object sender, EventArgs e)
        {

        }

        private void mtbCPFAluguel_Leave(object sender, EventArgs e)
        {


        }

        private void txtCodFuncVenda_Leave(object sender, EventArgs e)
        {
            if (txtCodFuncVenda.Text != string.Empty)
            {
                int codigo_funcionario = Convert.ToInt32(txtCodFuncVenda.Text);

                FuncionarioBanco funcionariobanco = new FuncionarioBanco();
                txtConfirmaNomeFuncionario.Text = (funcionariobanco.BuscarFuncionario_codigo(codigo_funcionario)).ToString();

            }
        }

        private void txtCodFuncAluga_Leave(object sender, EventArgs e)
        {
            if (txtCodFuncAluga.Text != string.Empty)
            {
                int codigo_funcionario = Convert.ToInt32(txtCodFuncAluga.Text);

                FuncionarioBanco funcionariobanco = new FuncionarioBanco();
                txtExibeNomeFuncionario.Text = (funcionariobanco.BuscarFuncionario_codigo(codigo_funcionario)).ToString();
            }
        }

        private void txtCodProdVenda_Leave(object sender, EventArgs e)
        {
            if (txtCodProdVenda.Text != string.Empty)
            {
                int codigo_produto = Convert.ToInt32(txtCodProdVenda.Text);

                JogosBanco jogosBanco = new JogosBanco();
                txtConfirmaNomeProduto.Text = (jogosBanco.buscaJogo_cod(codigo_produto)).ToString();
            }
        }

        private void txtCodProdAluga_Leave(object sender, EventArgs e)
        {
            if (txtCodProdAluga.Text != string.Empty)
            {
                int codigo_produto = Convert.ToInt32(txtCodProdAluga.Text);

                JogosBanco jogosBanco = new JogosBanco();
                txtExibeNomeJogo.Text = (jogosBanco.buscaJogo_cod(codigo_produto)).ToString();
            }
            
        }

        private void telaVenda_Load(object sender, EventArgs e)
        {
            //exibir os dados da tabela pagamento no campo de forma de pagamento


        }
    }
}
