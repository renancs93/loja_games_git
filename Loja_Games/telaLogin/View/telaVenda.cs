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
                numQuantidade.Value = 1;
            }
            else
            {
                MessageBox.Show("Dados Inválidos, tente novamente!", "Venda");
                txtCodProdVenda.Text = string.Empty;
                numQuantidade.Value = 1;
            }


        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            //Esse botão terá que remover um item da lista de compra do cliente

            if (dgvProdutosVenda.CurrentRow != null)
            {
                int linha = dgvProdutosVenda.CurrentRow.Index;

                DialogResult RmItem = MessageBox.Show("Deseja realmente remover o item?", "Venda", MessageBoxButtons.YesNo);

                if (RmItem == DialogResult.Yes)
                {
                    dgvProdutosVenda.Rows.RemoveAt(linha);
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!", "Remover Item");
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
                //pegar os dados no dataGrid linha a linha e inseri no Banco na tabela venda e dar baixa no estoque da tabela Jogos





                MessageBox.Show("Compra realizada com sucesso!");
                
                //gera o próximo codigo de venda
                VendaBanco gera_codigo = new VendaBanco();
                lbCodVenda.Text = ((1 + gera_codigo.codigoAtual_venda()).ToString());
                
                //Close();
                //telaP.Show();
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
            if(txtExibeNomeJogo.Text != "Nome do Jogo" || txtExibeNomeJogo.Text != "Jogo não encontrado")
            {
                int codigo = Convert.ToInt32(txtCodProdAluga.Text);

                VendaBanco jogo = new VendaBanco();
                List<Jogos> item = jogo.AddItem_ListaVenda(codigo);

                int dias = Convert.ToInt32(numDiasAlug.Value);
                float valor_total_aluguel = (item[0].Preco / 10) * dias;

                dgvProdutosAluga.Rows.Add(item[0].Codigo.ToString(), item[0].Nome.ToString(), dias, valor_total_aluguel);

                txtCodProdAluga.Text = string.Empty;
                numDiasAlug.Value = 1;
            }
            else
            {
                MessageBox.Show("Dados Inválidos!, tente novamente!", "Venda");
                txtCodProdAluga.Text = string.Empty;
                numDiasAlug.Value = 1;
            }
        }

        private void btnRemAlug_Click(object sender, EventArgs e)
        {
            //Esse botão terá que remover um item da lista de compra do cliente

            if(dgvProdutosAluga.CurrentRow != null)
            {
                int linha = dgvProdutosAluga.CurrentRow.Index;

                DialogResult removerItem = MessageBox.Show("Deseja realmente remover o item? ", "Aluguel", MessageBoxButtons.YesNo);

                if(removerItem == DialogResult.Yes)
                {
                    dgvProdutosAluga.Rows.RemoveAt(linha);
                }
            }
            else
            {
                MessageBox.Show("Nenhum produto selecionado!");
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
            if(mtbCPFVenda.Text.Trim() != string.Empty)
            {
                long cpf_cli = Convert.ToInt64(mtbCPFVenda.Text);
                ClienteBanco cliente = new ClienteBanco();
                txtConfirmaNomeCliente.Text = (cliente.Buscar_Cliente_apenasNome(cpf_cli)).ToString();

            }

        }

        private void mtbCPFAluguel_Leave(object sender, EventArgs e)
        {
            if (mtbCPFAluguel.Text.Trim() != string.Empty)
            {
                long cpf_cliente = Convert.ToInt64(mtbCPFAluguel.Text);
                ClienteBanco cliente = new ClienteBanco();
                txtExibeNomeCliente.Text = (cliente.Buscar_Cliente_apenasNome(cpf_cliente)).ToString();
            }

        }

        private void txtCodFuncVenda_Leave(object sender, EventArgs e)
        {
            if (txtCodFuncVenda.Text.Trim() != string.Empty)
            {
                int codigo_funcionario = Convert.ToInt32(txtCodFuncVenda.Text);

                FuncionarioBanco funcionariobanco = new FuncionarioBanco();
                txtConfirmaNomeFuncionario.Text = (funcionariobanco.BuscarFuncionario_codigo(codigo_funcionario)).ToString();

            }
        }

        private void txtCodFuncAluga_Leave(object sender, EventArgs e)
        {
            if (txtCodFuncAluga.Text.Trim() != string.Empty)
            {
                int codigo_funcionario = Convert.ToInt32(txtCodFuncAluga.Text);

                FuncionarioBanco funcionariobanco = new FuncionarioBanco();
                txtExibeNomeFuncionario.Text = (funcionariobanco.BuscarFuncionario_codigo(codigo_funcionario)).ToString();
            }
        }

        private void txtCodProdVenda_Leave(object sender, EventArgs e)
        {
            if (txtCodProdVenda.Text.Trim() != string.Empty)
            {
                int codigo_produto = Convert.ToInt32(txtCodProdVenda.Text);

                JogosBanco jogosBanco = new JogosBanco();
                txtConfirmaNomeProduto.Text = (jogosBanco.buscaJogo_cod(codigo_produto)).ToString();
            }
        }

        private void txtCodProdAluga_Leave(object sender, EventArgs e)
        {
            if (txtCodProdAluga.Text.Trim() != string.Empty)
            {
                int codigo_produto = Convert.ToInt32(txtCodProdAluga.Text);

                JogosBanco jogosBanco = new JogosBanco();
                txtExibeNomeJogo.Text = (jogosBanco.buscaJogo_cod(codigo_produto)).ToString();
            }
            
        }

        private void telaVenda_Load(object sender, EventArgs e)
        {
            //exibir os dados da tabela pagamento no campo de forma de pagamento de compra e aluga
            VendaBanco tiposPagamento = new VendaBanco();
            tiposPagamento.preencheTiposPagamento(cbxFormasPagamentosCompra);
            tiposPagamento.preencheTiposPagamento(cbxFormasPagamentoAluguel);

            //gera o próximo codigo de venda
            VendaBanco gera_codigo = new VendaBanco();
            lbCodVenda.Text = ((1 + gera_codigo.codigoAtual_venda()).ToString());
        }

        private Venda populaVenda()
        {
            Venda v = new Venda();

            //pegar os dados de uma linha do dataGrid


            return v;
        }


        //os eeventos de adição e remoção de linha no datagrid servirão pra atualizar os Valores total de compras e valor das parcelas
        private void dgvProdutosVenda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int qntProdutos = dgvProdutosVenda.Rows.Count;
            float total = 0;

            for(int x=0; x < qntProdutos; x++)
            {
                total += float.Parse((dgvProdutosVenda[4,x].Value).ToString());
            }
            
            txtTotalCompra.Text = total.ToString();
            txtValorParcela.Text = ((total) / (double)(numParcelas_Venda.Value)).ToString();

        }

        private void dgvProdutosVenda_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int qtdeProdutos = dgvProdutosVenda.Rows.Count;
            float totalVenda = 0;

            for(int x = 0; x<qtdeProdutos; x++)
            {
                totalVenda += float.Parse((dgvProdutosVenda[4,x].Value).ToString());
            }
            txtTotalCompra.Text = totalVenda.ToString();
            txtValorParcela.Text = ((totalVenda) / (double)(numParcelas_Venda.Value)).ToString();
        }

        private void numParcelas_Venda_ValueChanged(object sender, EventArgs e)
        {
            txtValorParcela.Text = Convert.ToString(((float.Parse(txtTotalCompra.Text)) / (int.Parse(numParcelas_Venda.Value.ToString()))));
        }

        private void dgvProdutosAluga_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int qtdeProdutos = dgvProdutosAluga.Rows.Count;

            float total = 0;

            for(int x = 0; x < qtdeProdutos; x++)
            {
                total += float.Parse((dgvProdutosAluga[3,x].Value).ToString());
            }
            txtTotalAluguel.Text = total.ToString();
        }

        private void dgvProdutosAluga_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int qtdeProdutos = dgvProdutosAluga.Rows.Count;
            float totalAluguel = 0;

            for(int x = 0; x < qtdeProdutos; x++)
            {
                totalAluguel += float.Parse((dgvProdutosAluga[3,x].Value).ToString());
            }

            txtTotalAluguel.Text = totalAluguel.ToString();
        }
    }
}
