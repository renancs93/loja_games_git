using LojaGames.Controller;
using System.Windows.Forms;
using System;
using LojaGames.Model;

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

            if ((nome == string.Empty) && (cpf == string.Empty))
            {
                DialogResult busca = MessageBox.Show("O Campo CPF ou Campo Nome devem ser preenchido!", "Busca!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                //irá realizar a busca de acordo com os dados fornecido em uns dos campos
                //caso não encontrado nenhum valor no banco correspondente exibir mensagem e mostrar todos

            }
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
            DialogResult rm = MessageBox.Show("Deseja remover o Cliente selecionado?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rm == DialogResult.Yes)
            {
                MessageBox.Show("Cliente removido com Sucesso");
            }
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
    }
}
