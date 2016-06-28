using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LojaGames.Classes;
using LojaGames.Controller;
using LojaGames.Model;

namespace LojaGames
{
    public partial class telaVenda : Form
    {
        private Form telaP = null;
        Jogos jogos = new Jogos();
        JogosBanco jogoBanco = new JogosBanco();
        FuncionarioBanco fbanco = new FuncionarioBanco();
        Venda v = new Venda();
        Aluguel a = new Aluguel();
        Pagamento pagamento = new Pagamento();
        int qtdeVendida;
        int qtdeProdutoAtual;

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
            qtdeVendida = Convert.ToInt32(numQuantidade.Value);
            JogosBanco jogoBanco = new JogosBanco();
            qtdeProdutoAtual = jogoBanco.QuantidadeAtual(Convert.ToInt32(txtCodProdVenda.Text));

            if(qtdeVendida <= qtdeProdutoAtual)
            {
                if (txtConfirmaNomeProduto.Text != "Nome do Jogo" || txtConfirmaNomeProduto.Text != "Jogo não encontrado")
                {
                    int codigo = Convert.ToInt32(txtCodProdVenda.Text);

                    VendaBanco jogo = new VendaBanco();
                    List<Jogos> item = jogo.AddItem_ListaVenda(codigo);

                    int quantidade = Convert.ToInt32(numQuantidade.Value);
                    float valor_total_item = (item[0].Preco) * (quantidade);

                    //dgvProdutosVenda.Rows.Add(item[0].Codigo.ToString(), item[0].Nome.ToString(), item[0].Preco.ToString(), quantidade, valor_total_item);
                    dgvProdutosVenda.Rows.Add(mtbCPFVenda.Text, fbanco.BuscarFuncionario_codigo_retornaCPF(int.Parse(txtCodFuncVenda.Text)), item[0].Codigo.ToString(), item[0].Nome, item[0].Preco.ToString(), quantidade, valor_total_item);

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
            else
            {
                MessageBox.Show("Quantidade insuficiente no estoque!", "Atenção!", MessageBoxButtons.OK);
            }
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            //Esse botão terá que remover um item da lista de compra do cliente
            JogosBanco jogoBanco = new JogosBanco();
            
            if (dgvProdutosVenda.CurrentRow != null)
            {
                int linha = dgvProdutosVenda.CurrentRow.Index;
                qtdeVendida = Convert.ToInt32(dgvProdutosVenda[5, linha].Value);
                int codigoAtual = Convert.ToInt32(dgvProdutosVenda[2, linha].Value);

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
            DialogResult FecharAluguel = MessageBox.Show("Deseja realmente finalizar o aluguel?", "Finalizar Compra", MessageBoxButtons.YesNo);
            if(FecharAluguel == DialogResult.Yes)
            {
                AluguelBanco aluguelBanco = new AluguelBanco();

                //pegar os dados no dataGrid linha a linha e inseri no Banco na tabela venda e dar baixa no estoque da tabela Jogos
                int quantidadeItems = dgvProdutosAluga.RowCount;

                for(int i = 0; i < quantidadeItems; i++)
                {
                    int codigoAluguel = int.Parse(lbCodAlug.Text);
                    string colunaCPF_Cliente = (dgvProdutosAluga[0, i].Value.ToString());
                    string colunaCPF_Funcionario = (dgvProdutosAluga[1, i].Value.ToString());
                    int colunaCodigo = Convert.ToInt32(dgvProdutosAluga[2, i].Value);
                    int diasAluguel = Convert.ToInt32(dgvProdutosAluga[4, i].Value);
                    double valor_total = Convert.ToDouble(dgvProdutosAluga[5, i].Value);
                    string pagamento = cbxFormasPagamentoAluguel.Text;
                    qtdeProdutoAtual = jogoBanco.QuantidadeAtual(Convert.ToInt32(dgvProdutosAluga[2, i].Value));

                    int qtdeAtualizada = (qtdeProdutoAtual - 1);
                    jogoBanco.AtualizaQtde(qtdeAtualizada, colunaCodigo);

                    aluguelBanco.RegistraAluguel(populaAluguel(codigoAluguel, colunaCPF_Cliente, colunaCPF_Funcionario, colunaCodigo, diasAluguel, valor_total, pagamento));
                }

                MessageBox.Show("Aluguel realizada com sucesso!");
                ClasseUtil.LimparCampos(abaAluguel.Controls);
                dgvProdutosAluga.Rows.Clear();
                
                //atualiza o codigo do aluguel
                lbCodAlug.Text = (1 + aluguelBanco.codigoAtual_Aluguel()).ToString();
            }
        }

        private void btnAddAlug_Click(object sender, EventArgs e)
        {
            qtdeProdutoAtual = jogoBanco.QuantidadeAtual(Convert.ToInt32(txtCodProdAluga.Text));

            if(qtdeProdutoAtual != 0)
            {
                if (txtExibeNomeJogo.Text != "Nome do Jogo" || txtExibeNomeJogo.Text != "Jogo não encontrado")
                {
                    int codigo = Convert.ToInt32(txtCodProdAluga.Text);

                    VendaBanco jogo = new VendaBanco();
                    List<Jogos> item = jogo.AddItem_ListaVenda(codigo);

                    int dias = Convert.ToInt32(numDiasAlug.Value);
                    float valor_total_aluguel = (item[0].Preco / 10) * dias;

                    dgvProdutosAluga.Rows.Add(mtbCPFAluguel.Text, fbanco.BuscarFuncionario_codigo_retornaCPF(int.Parse(txtCodFuncAluga.Text)), item[0].Codigo.ToString(), item[0].Nome.ToString(), dias, valor_total_aluguel);

                    txtCodProdAluga.Text = string.Empty;
                    numDiasAlug.Value = 1;
                }
                else
                {
                    MessageBox.Show("Dados Inválidos!, tente novamente!", "Aluga");
                    txtCodProdAluga.Text = string.Empty;
                    numDiasAlug.Value = 1;
                }
            }
            else
            {
                MessageBox.Show("Quantidade insuficiente no estoque!", "Atenção!", MessageBoxButtons.OK);
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
            lbCodVenda.Text = (1 + gera_codigo.codigoAtual_venda()).ToString();

            AluguelBanco gera_codigo_atual = new AluguelBanco();
            lbCodAlug.Text = (1 + gera_codigo_atual.codigoAtual_Aluguel()).ToString();
        }

        //os eeventos de adição e remoção de linha no datagrid servirão pra atualizar os Valores total de compras e valor das parcelas
        private void dgvProdutosVenda_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int qntProdutos = dgvProdutosVenda.Rows.Count;
            float total = 0;

            for(int x=0; x < qntProdutos; x++)
            {
                total += float.Parse((dgvProdutosVenda[6,x].Value).ToString());
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
                total += float.Parse((dgvProdutosAluga[5,x].Value).ToString());
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

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {

            DialogResult FecharCompra = MessageBox.Show("Deseja realmente finalizar a venda?", "Finalizar Compra", MessageBoxButtons.YesNo);

            if (FecharCompra == DialogResult.Yes)
            {
                VendaBanco venda = new VendaBanco();

                //pegar os dados no dataGrid linha a linha e inseri no Banco na tabela venda e dar baixa no estoque da tabela Jogos
                int quantidadeItems = dgvProdutosVenda.RowCount;

                for(int i=0 ; i<quantidadeItems; i++)
                {
                    int codigoVenda = int.Parse(lbCodVenda.Text);
                    string colunaCpf_cliente = (dgvProdutosVenda[0, i].Value.ToString());
                    string colunaCpf_funcionario = (dgvProdutosVenda[1, i].Value.ToString());
                    int colunaCodigo = Convert.ToInt32(dgvProdutosVenda[2, i].Value);
                    int quantidade = Convert.ToInt32(dgvProdutosVenda[5, i].Value.ToString());
                    double valorTotal = Convert.ToDouble(dgvProdutosVenda[6, i].Value);
                    string pagamento = cbxFormasPagamentosCompra.Text;
                    qtdeVendida = Convert.ToInt32(dgvProdutosVenda[5, i].Value);
                    qtdeProdutoAtual = jogoBanco.QuantidadeAtual(Convert.ToInt32(dgvProdutosVenda[2, i].Value));

                    int qtdeAtualizada = (qtdeProdutoAtual - qtdeVendida);
                    jogoBanco.AtualizaQtde(qtdeAtualizada, colunaCodigo);

                    venda.registraVenda(populaVenda(codigoVenda, colunaCpf_cliente, colunaCpf_funcionario, colunaCodigo, quantidade, valorTotal, pagamento));
                }

                MessageBox.Show("Compra realizada com sucesso!");
                ClasseUtil.LimparCampos(abaVenda.Controls);
                dgvProdutosVenda.Rows.Clear();
                
                VendaBanco gera_codigo = new VendaBanco();
                lbCodVenda.Text = Convert.ToString(1 + gera_codigo.codigoAtual_venda());
            }
        }

        private Venda populaVenda(int codigoV, string cpf_cliente, string cpf_funcionario, int codigo, int qtde, double total, string pag)
        {
            //pegar os dados de uma linha do dataGrid

            v.CodigoVenda = codigoV;
            v.CPF_Cliente = cpf_cliente;
            v.CPF_Funcionario = cpf_funcionario;
            v.CodJogos = codigo;
            v.Quantidade = qtde;
            v.Total = float.Parse(total.ToString());
            v.Pagamento = pag;

            return v;
        }

        private Aluguel populaAluguel(int codigoA, string cpf_cli, string cpf_func, int codigo, int dias, double total, string pag)
        {
            a.CodigoAluguel = codigoA;
            a.CPF_Cliente = cpf_cli;
            a.CPF_Funcionario = cpf_func;
            a.CodigoJogo = codigo;
            a.Dias = dias;
            a.ValorTotal = float.Parse(total.ToString());
            a.Pagamento = pag;

            return a;
        }
    }
}
