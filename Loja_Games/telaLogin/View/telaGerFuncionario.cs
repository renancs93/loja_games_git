using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using LojaGames.Classes;
using LojaGames.Controller;
using LojaGames.Model;
using LojaGames.ServiceReferenceCorreios;
using MySql.Data.MySqlClient;

namespace LojaGames.View
{
    public partial class telaGerFuncionario : Form
    {
        private Form telaP = null;
        private long cpfAntigo;
        FuncionarioBanco funcionarioBanco = new FuncionarioBanco();
        PessoaBanco pessoaBanco = new PessoaBanco();

        public telaGerFuncionario()
        {
            InitializeComponent();
            
        }

        public void setTelaAnterior(Form t)
        {
            telaP = t;
        }

        private void telaGerFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }

        private void btnCadastro_Click(object sender, System.EventArgs e)
        {
            DadosLoginFuncionario telaLoginSenha = new DadosLoginFuncionario(imgUserSenhaOKFunc);
            imgUserSenhaOKFunc.Visible = false;
            telaLoginSenha.Show();
        }

        private void btnCadastrarFuncionario_Click(object sender, System.EventArgs e)
        {
            //realiza as verificações dos campos antes de cadastrar
            string MensagemErro = "";
            MensagemErro = ClasseUtil.ValidaCampos(abaCadFuncionario.Controls);

            if (MensagemErro == "")
            {
                /*instancio a classe(controller) FuncionariBanco para poder usar o metodo dessa classe
                * chamo esse metodo passando como parametro o objeto retornado do metodo da tela populaNovoFuncionario  
                */

                /* tirar esse comentario qnd estiver tudo OK
                if (imgUserSenhaOKFunc.Visible == false)
                {
                    MessageBox.Show("É necessário definir um USUÁRIO e SENHA para o funcionário");
                }
                else
                {
                */
                    if (btnCadastrarFunc.Text == "Cadastrar")
                    {
                        funcionarioBanco.SalvarFuncionario(popularFuncionario());

                        DialogResult cadastrado = MessageBox.Show("Funcionário cadastrado com sucesso.", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ClasseUtil.LimparCampos(abaCadFuncionario.Controls);
                    }
                    else if (btnCadastrarFunc.Text == "Salvar")
                    {
                        //implementação de uma edição de um funcionário

                        Funcionario dados = popularFuncionario();        

                        funcionarioBanco.AtualizarFuncionario(cpfAntigo , dados);
                        pessoaBanco.AtualizarPessoa(cpfAntigo, dados);

                        DialogResult edicao = MessageBox.Show("Funcionário alterado com sucesso.", "Edição!", MessageBoxButtons.OK, MessageBoxIcon.None);
                        ClasseUtil.LimparCampos(abaCadFuncionario.Controls);
                        btnCadastrarFunc.Text = "Cadastrar";

                        mtbCpfFunc.Enabled = true;
                        abasGerFuncionario.SelectedTab = abaExibiFuncionario;
                    dgvExibeFunc.RefreshEdit();
                }
                }
                //Close();
                //telaP.Show();
            //}
            else
            {
                DialogResult alerta = MessageBox.Show(MensagemErro, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            lbCodFunc.Text = (1 + funcionarioBanco.gerar_codigoFunc()).ToString();
            btnExibirTodosFunc_Click(sender, e);
            dgvExibeFunc.RefreshEdit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Os dados serão perdidos! \n Deseja mesmo sair da tela de cadastro? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cancel == DialogResult.Yes)
            {
                telaP.Show();
                Close();
            }
        }

        private Funcionario popularFuncionario()
        {
            Funcionario f = new Funcionario();

            //Popula Dados Pessoais
            f.CPF = long.Parse(mtbCpfFunc.Text);
            f.Nome = txtNomeFunc.Text;
            f.RG = mtbRgFunc.Text;
            f.DataNascimento = Convert.ToDateTime(dtpDataNascFunc.Text);//ToString("yyyy-MM-dd");

            //verifica a opção do sexo selecionada
            if (rbtnMasculinoFunc.Checked == true)
            {
                f.Sexo = char.Parse("M");
            }
            else if (rbtnFemininoFunc.Checked == true)
            {
                f.Sexo = char.Parse("F");
            }
            else
            {
                f.Sexo = char.Parse("I");
            }

            f.EstadoCivil = cbxEstCivilFunc.Text;
            f.Telefone = mtbTelefoneFunc.Text;
            f.Email = txtEmailFunc.Text;
            
            //Popula Endereço
            f.Cep = mtbCepFunc.Text;
            f.Rua = txtRuaFunc.Text;
            f.Numero = int.Parse(txtNumFunc.Text);
            f.Bairro = txtBairroFunc.Text;
            f.Estado = cbxEstadoFunc.Text;
            f.Cidade = txtCidadeFunc.Text;

            //dados somente de funcionario
            f.Codigo_Funcionario = Convert.ToInt32(lbCodFunc.Text);

            f.Cargo = txtCargoFunc.Text;
            if(txtSalarioBaseFunc.Text != string.Empty)
            {
                f.Salario_Base = float.Parse(txtSalarioBaseFunc.Text);
            }
            f.Data_Inicio = Convert.ToDateTime(dtpDataInicioFunc.Text);
    
            //popular o usuário e a senha (FAZER)
            

            return f;
        }

        private void PreencheCamposFuncionario(Funcionario f)
        {
            //Funcionario
            mtbCpfFunc.Text = f.CPF.ToString();
            txtCargoFunc.Text = f.Cargo.ToString();
            dtpDataInicioFunc.Text = f.Data_Inicio.ToString();
            txtSalarioBaseFunc.Text = f.Salario_Base.ToString();

            lbCodFunc.Text = f.Codigo_Funcionario.ToString();
        }

        private void PreencheCamposPessoa(Pessoa p)
        {
            //Pessoa
            txtNomeFunc.Text = p.Nome.ToString();
            txtRuaFunc.Text = p.Rua.ToString();
            mtbRgFunc.Text = p.RG.ToString();
            dtpDataNascFunc.Text = p.DataNascimento.ToString();

            if(p.Sexo.ToString() == "M")
            {
                rbtnMasculinoFunc.Checked = true;
            }
            else if (p.Sexo.ToString() == "F")
            {
                rbtnFemininoFunc.Checked = true;
            }
            else if(p.Sexo.ToString() == "I")
            {
                rbtnNInformadoFunc.Checked = true;
            }

            cbxEstCivilFunc.Text = p.EstadoCivil.ToString();
            mtbTelefoneFunc.Text = p.Telefone.ToString();
            txtEmailFunc.Text = p.Email.ToString();
            mtbCepFunc.Text = p.Cep.ToString();
            txtRuaFunc.Text = p.Rua.ToString();
            txtNumFunc.Text = p.Numero.ToString();
            txtBairroFunc.Text = p.Bairro.ToString();
            txtCidadeFunc.Text = p.Cidade.ToString();
            cbxEstadoFunc.Text = p.Estado.ToString();
        }

        private void btnExibirTodosFunc_Click(object sender, System.EventArgs e)
        {
            int x = dgvExibeFunc.RowCount;
            
            if (x > 0)
            {
                dgvExibeFunc.RefreshEdit();
                //for (int i = 0; i < x; i++)
                //  dgvExibeFunc.Rows.RemoveAt(i); //limpa o datagrid
            }
            
            funcionarioBanco.ExibirTodosFuncionario(dgvExibeFunc); 
        }

        private void btnSairExibi_Click(object sender, System.EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Deseja realmente sair? ", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                telaP.Show();
                Close();
            }
        }

        private void btnBuscarFunc_Click(object sender, System.EventArgs e)
        {
            string nome = txtNomeExiFunc.Text;
            string cpf = mtbCpfExiFunc.Text;

            //irá realizar a busca de acordo com os dados fornecido em uns dos campos
            //caso não encontrado nenhum valor no banco correspondente exibir mensagem e mostrar todos
            if ((nome == string.Empty) && (cpf == string.Empty))
            {
                DialogResult busca = MessageBox.Show("O Campo CPF ou Campo Nome devem ser preenchido!", "Busca!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if((nome == string.Empty) && (cpf != string.Empty))
            {
                //exibe a busca por cpf 
                dgvExibeFunc.DataSource = funcionarioBanco.BuscarFuncionario_cpf(cpf);
            }
            else if((cpf == string.Empty) && (nome != string.Empty))
            {
                //exibe a busca por nome 
                dgvExibeFunc.DataSource = funcionarioBanco.BuscarFuncionario_nome(nome);            
            }
            else
            {
                MessageBox.Show("Por gentileza, preencha apenas um dos campos para Busca", "Dados", MessageBoxButtons.OK ,MessageBoxIcon.Information);
                ClasseUtil.LimparCampos(abaExibiFuncionario.Controls);
            }

            ClasseUtil.LimparCampos(abaExibiFuncionario.Controls);
        }

        private void btnEditarFunc_Click(object sender, System.EventArgs e)
        {
            if (dgvExibeFunc.CurrentRow != null)
            {
                //pega a linha no dataGrid selecionada e abre a telaCadastro de funcionário já setados para alteração
                int linha = dgvExibeFunc.CurrentRow.Index;

                DialogResult edit = MessageBox.Show("Deseja editar o Funcionário selecionado?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (edit == DialogResult.Yes)
                {
                    abasGerFuncionario.SelectedTab = abaCadFuncionario;
                    
                    PessoaBanco p = new PessoaBanco();
                    FuncionarioBanco f = new FuncionarioBanco();

                    cpfAntigo = long.Parse((dgvExibeFunc[0, linha].Value).ToString());
                    PreencheCamposPessoa(p.BuscarPessoa(Convert.ToInt64(dgvExibeFunc[0, linha].Value.ToString())));
                    PreencheCamposFuncionario(f.BuscarFuncionario(Convert.ToInt64(dgvExibeFunc[0, linha].Value.ToString())));

                    btnCadastrarFunc.Text = "Salvar";
                    mtbCpfFunc.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado");
            }
            //btnExibirTodosFunc_Click(sender, e);
            //dgvExibeFunc.RefreshEdit();
        }

        private void btnExcluirFunc_Click(object sender, System.EventArgs e)
        {
            if (dgvExibeFunc.CurrentRow != null)
            {
                DialogResult rm = MessageBox.Show("Deseja remover o Cliente selecionado?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                int linha = dgvExibeFunc.CurrentRow.Index;

                if (rm == DialogResult.Yes)
                {
                    long cpf = Convert.ToInt64(dgvExibeFunc[0, linha].Value.ToString());

                    funcionarioBanco.RemoverFuncionario(cpf);
                    pessoaBanco.RemoverPessoa(cpf);

                    MessageBox.Show("Cliente removido com Sucesso");

                    btnExibirTodosFunc_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Nenhum funcionário selecionado");
            }
            dgvExibeFunc.RefreshEdit();
        }

        private void txtSalarioBaseFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //força o campo a receber apenas numeros (estilo monetários)
            ClasseUtil.somenteValores(txtSalarioBaseFunc, e);
        }

        private void telaGerFuncionario_Load(object sender, EventArgs e)
        {
            lbCodFunc.Text = (1 + funcionarioBanco.gerar_codigoFunc()).ToString();
        }

        private void dgvExibeFunc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = dgvExibeFunc.CurrentRow.Index;

            dgvExibeFunc.Rows[linha].Selected = true;
        }

        private void txtNumFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ClasseUtil.apenasNumeros(txtNumFunc, e);
        }

        private void mtbCepFunc_Leave(object sender, EventArgs e)
        {
            if (mtbCepFunc.Text != string.Empty)
            {
                try
                {
                    AtendeClienteClient ws = new AtendeClienteClient("AtendeClientePort"); //Verificar o nome do endpoint no arquivo Web.config
                    var dados = ws.consultaCEP(mtbCepFunc.Text);
                    if (dados != null)
                    {
                        //MessageBox.Show(dados.cidade);
                        //preenche os campos da tela com as informações retornadas do WebService dos Correios
                        txtRuaFunc.Text = dados.end;
                        txtBairroFunc.Text = dados.bairro;
                        txtCidadeFunc.Text = dados.cidade;
                        cbxEstadoFunc.Text = dados.uf;

                        mtbCepFunc.BackColor = System.Drawing.Color.Green;
                        txtNumFunc.Focus();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //MessageBox.Show("CEP não encontrado");
                    mtbCepFunc.Text = string.Empty;

                    txtRuaFunc.Text = string.Empty;
                    txtBairroFunc.Text = string.Empty;
                    txtCidadeFunc.Text = string.Empty;
                    cbxEstadoFunc.Text = string.Empty;

                    mtbCepFunc.BackColor = System.Drawing.Color.Red;
                    mtbCepFunc.Focus();
                }
            }
            else
                mtbCepFunc.BackColor = System.Drawing.Color.White;
        }

        private void mtbCepFunc_TextChanged(object sender, EventArgs e)
        {
            mtbCepFunc.BackColor = System.Drawing.Color.White;
        }
    }
}
