using LojaGames.Controller;
using System.Windows.Forms;
using System;
using LojaGames.Model;
using LojaGames.ServiceReferenceCorreios;

namespace LojaGames.View
{
    public partial class telaGerCliente : Form
    {
        private Form telaP = null;
        ClienteBanco clienteBanco = new ClienteBanco();
        PessoaBanco pessoaBanco = new PessoaBanco();
        private long cpfAntigoCliente;

        public telaGerCliente()
        {
            InitializeComponent();
        }

        public void setTelaAnterior(Form t)
        {
            telaP = t;
        }

        private void telaGerCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }

        private void btnSairCli_Click(object sender, System.EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sair == DialogResult.Yes)
            {
                telaP.Show();
                Close();
            }
        }

        private void btnExibirTodosCli_Click(object sender, System.EventArgs e)
        {
            int x = dgvExibeCli.RowCount;

            if (x > 0)
            {
                dgvExibeCli.RefreshEdit();          
            }
            clienteBanco.ExibirTodosClientes(dgvExibeCli);
        }

        private void btnBuscarCli_Click(object sender, System.EventArgs e)
        {
            string nome = txtNomeExiCli.Text;
            string cpf = mtbCpfExiCli.Text;

            //irá realizar a busca de acordo com os dados fornecidos em um dos campos
            //caso não encontrado nenhum valor no banco correspondente exibir mensagem e mostrar todos

            if((nome == string.Empty) && (cpf == string.Empty))
            {
                DialogResult resultadoBusca = MessageBox.Show("O campo CPF ou Nome deve ser preenchido!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if((nome == string.Empty) && (cpf !=string.Empty))
            {
                //exibe a busca pelo CPF
                dgvExibeCli.DataSource = clienteBanco.BuscarCliente_CPF(cpf);
            }
            else if((cpf == string.Empty) && (nome != string.Empty))
            {
                dgvExibeCli.DataSource = clienteBanco.BuscarCliente_NOME(nome);
            }
            else
            {
                MessageBox.Show("Por gentileza, preencha apenas um dos campos para Busca!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClasseUtil.LimparCampos(abaExibiCliente.Controls);
            }
            ClasseUtil.LimparCampos(abaExibiCliente.Controls);
        }

        private void btnEditarCli_Click(object sender, System.EventArgs e)
        {
            if(dgvExibeCli.CurrentRow != null)
            {
                int linha = dgvExibeCli.CurrentRow.Index;

                DialogResult edicao = MessageBox.Show("Deseja editar o cliente selecionado?", "Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(edicao == DialogResult.Yes)
                {
                    abasGerCliente.SelectedTab = abaCadCliente;

                    PessoaBanco p = new PessoaBanco();
                    ClienteBanco c = new ClienteBanco();

                    cpfAntigoCliente = long.Parse((dgvExibeCli[0, linha].Value).ToString());
                    PreencheCamposPessoa(p.BuscarPessoa(Convert.ToInt64(dgvExibeCli[0, linha].Value.ToString())));
                    PreencheCamposCliente(c.Buscar_Cliente(Convert.ToInt64(dgvExibeCli[0, linha].Value.ToString())));

                    btnCadastrarCli.Text = "Salvar";
                    mtbCpfCli.Enabled = false;
                }                
            }
            else
            {
                MessageBox.Show("Nenhum cliente foi selecionado!");
            }
        }

        private void btnExcluirCli_Click(object sender, System.EventArgs e)
        {
            if(dgvExibeCli.CurrentRow != null)
            {
                DialogResult remover = MessageBox.Show("Deseja remover o cliente selecionado?", "Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                int linha = dgvExibeCli.CurrentRow.Index;

                if(remover == DialogResult.Yes)
                {
                    long cpf_cliente = Convert.ToInt64(dgvExibeCli[0, linha].Value.ToString());

                    clienteBanco.RemoverCliente(cpf_cliente);
                    pessoaBanco.RemoverPessoa(cpf_cliente);

                    MessageBox.Show("Cliente Removido com Sucesso!");

                    btnExibirTodosCli_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado!");
            }
            dgvExibeCli.RefreshEdit();
        }

        private void btnCancelarCli_Click(object sender, System.EventArgs e)
        {
            DialogResult cancelar = MessageBox.Show("Os dados serão perdidos!\n Deseja realmente Cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cancelar == DialogResult.Yes)
            {
                Close();
                telaP.Show();
            }
        }

        private void btnCadastrarCli_Click(object sender, System.EventArgs e)
        {
            //verificar campos e salvar na lista/banco
            string MensagemErro = "";
            MensagemErro = ClasseUtil.ValidaCampos(abaCadCliente.Controls);

            if(MensagemErro == "")
            {
                //salvar objeto na classe e lista
                //salvar objeto na classe e lista
                if (btnCadastrarCli.Text == "Cadastrar")
                {
                    clienteBanco.SalvarCliente(PopularCliente());

                    DialogResult cadastro = MessageBox.Show("Cliente Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ClasseUtil.LimparCampos(abaCadCliente.Controls);
                }
                else if(btnCadastrarCli.Text == "Salvar")
                {
                    Cliente dados = PopularCliente();

                    pessoaBanco.AtualizarPessoaCliente(cpfAntigoCliente, dados);

                    DialogResult edicaoCliente = MessageBox.Show("Funcionário alterado com sucesso.", "Edição!", MessageBoxButtons.OK, MessageBoxIcon.None);
                    ClasseUtil.LimparCampos(abaCadCliente.Controls);
                    btnCadastrarCli.Text = "Cadastrar";

                    mtbCpfCli.Enabled = true;
                    abasGerCliente.SelectedTab = abaExibiCliente;
                    dgvExibeCli.RefreshEdit();
                }                
            }
            else
            {
                DialogResult alerta = MessageBox.Show(MensagemErro, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            btnExibirTodosCli_Click(sender, e);
            dgvExibeCli.RefreshEdit();
        }

        private Cliente PopularCliente() //Método para popular o objeto do tipo Cliente
        {
            Cliente c = new Cliente();

            //Popular Dados Pessoais
            c.CPF = long.Parse(mtbCpfCli.Text);
            c.Nome = txtNomeCli.Text;
            c.RG = mtbRgCli.Text;
            c.DataNascimento = Convert.ToDateTime(dtpDataNascCli.Text);

            if (rbtnMasculinoCli.Checked == true)
            {
                c.Sexo = char.Parse("M");
            }
            else if (rbtnFemininoCli.Checked == true)
            {
                c.Sexo = char.Parse("F");
            }
            else
            {
                c.Sexo = char.Parse("I");
            }

            c.EstadoCivil = cbxEstadoCivilCli.Text;
            c.Telefone = mtbTelefoneCli.Text;
            c.Email = txtEmailCli.Text;

            //Popula o Endereço
            c.Cep = mtbCepCli.Text;
            c.Rua = txtRuaCli.Text;
            c.Numero = int.Parse(txtNumeroCli.Text);
            c.Bairro = txtBairroCli.Text;
            c.Estado = cbxEstadoCli.Text;
            c.Cidade = txtCidadeCli.Text;

            return c;
        }

        private void PreencheCamposPessoa(Pessoa p)
        {
            //Pessoa
            txtNomeCli.Text = p.Nome.ToString();
            txtRuaCli.Text = p.Rua.ToString();
            mtbRgCli.Text = p.RG.ToString();
            dtpDataNascCli.Text = p.DataNascimento.ToString();

            if (p.Sexo.ToString() == "M")
            {
                rbtnMasculinoCli.Checked = true;
            }
            else if (p.Sexo.ToString() == "F")
            {
                rbtnFemininoCli.Checked = true;
            }
            else if (p.Sexo.ToString() == "I")
            {
                rbtnNaoInformadoCli.Checked = true;
            }

            cbxEstadoCivilCli.Text = p.EstadoCivil.ToString();
            mtbTelefoneCli.Text = p.Telefone.ToString();
            txtEmailCli.Text = p.Email.ToString();
            mtbCepCli.Text = p.Cep.ToString();
            txtRuaCli.Text = p.Rua.ToString();
            txtNumeroCli.Text = p.Numero.ToString();
            txtBairroCli.Text = p.Bairro.ToString();
            txtCidadeCli.Text = p.Cidade.ToString();
            cbxEstadoCli.Text = p.Estado.ToString();
        }

        private void PreencheCamposCliente(Cliente c)
        {
            //Funcionario
            mtbCpfCli.Text = c.CPF.ToString();            
        }

        private void txtNumeroCli_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseUtil.apenasNumeros(txtNumeroCli, e);
        }

        private void mtbCepCli_Leave(object sender, EventArgs e)
        {
            if (mtbCepCli.Text != string.Empty)
            {
                try
                {
                    AtendeClienteClient ws = new AtendeClienteClient("AtendeClientePort"); //Verificar o nome do endpoint no arquivo Web.config
                    var dados = ws.consultaCEP(mtbCepCli.Text);
                    if (dados != null)
                    {
                        //MessageBox.Show(dados.cidade);
                        //preenche os campos da tela com as informações retornadas do WebService dos Correios
                        txtRuaCli.Text = dados.end;
                        txtBairroCli.Text = dados.bairro;
                        txtCidadeCli.Text = dados.cidade;
                        cbxEstadoCli.Text = dados.uf;

                        mtbCepCli.BackColor = System.Drawing.Color.Green;

                        //chama metodo para alterar o estado ENABLE dos campos do endereço
                        habilitaCamposEndereco();

                        //deixa o cursor setado no campo de numero
                        txtNumeroCli.Focus();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("CEP não encontrado");
                    mtbCepCli.Text = string.Empty;

                    limpaCamposEndereco();

                    mtbCepCli.BackColor = System.Drawing.Color.Red;
                    mtbCepCli.Focus();
                }
            }
            else
                mtbCepCli.BackColor = System.Drawing.Color.White;


        }

        private void mtbCepCli_TextChanged(object sender, EventArgs e)
        {
            mtbCepCli.BackColor = System.Drawing.Color.White;
            limpaCamposEndereco();
        }

        private void limpaCamposEndereco()
        {
            txtRuaCli.Text = string.Empty;
            txtBairroCli.Text = string.Empty;
            txtCidadeCli.Text = string.Empty;
            cbxEstadoCli.SelectedIndex = -1;

            habilitaCamposEndereco();
        }

        private void habilitaCamposEndereco()
        {
            //caso os campos trazerem dados, desabilita para não serem alterados
            if (txtRuaCli.Text != string.Empty)
            {
                txtRuaCli.Enabled = false;
            }
            else
                txtRuaCli.Enabled = true;

            if (txtBairroCli.Text != string.Empty)
            {
                txtBairroCli.Enabled = false;
            }
            else
                txtBairroCli.Enabled = true;

            if (txtCidadeCli.Text != string.Empty)
            {
                txtCidadeCli.Enabled = false;
            }
            else
                txtCidadeCli.Enabled = true;

            if (cbxEstadoCli.Text != string.Empty)
            {
                cbxEstadoCli.Enabled = false;
            }
            else
                cbxEstadoCli.Enabled = true;
        }


    }
}
