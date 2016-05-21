using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LojaGames.Classes;
using LojaGames.Controller;
using LojaGames.Model;

namespace LojaGames.View
{
    public partial class telaGerFuncionario : Form
    {
        private Form telaP = null;


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
            //realizar as verificações dos campos antes de cadastrar
            string MensagemErro = "";
            //MensagemErro = ClasseUtil.ValidaCampos(abaCadFuncionario.Controls);

            if (MensagemErro == "")
            {
                /*instancio a classe(controller) FuncionariBanco para poder usar o metodo dessa classe
                * chamo esse metodo passando como parametro o objeto retornado do metodo da tela populaNovoFuncionario  
                */
                FuncionarioBanco funcionarioBanco = new FuncionarioBanco();
                funcionarioBanco.SalvarFuncionario(popularNovoFuncionario());

                DialogResult cadastrado = MessageBox.Show("Funcionário cadastrado com sucesso.", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.None);
                ClasseUtil.LimparCampos(abaCadFuncionario.Controls);
                //Close();
                //telaP.Show();
            }
            else
            {
                DialogResult alerta = MessageBox.Show(MensagemErro, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Os dados serão perdidos! \n Deseja mesmo sair da tela de cadastro? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (cancel == DialogResult.Yes)
            {
                telaP.Show();
                Close();
            }
        }

        private Funcionario popularNovoFuncionario()
        {
            Funcionario f = new Funcionario();

            f.CPF = long.Parse(mtbCpfFunc.Text);
            f.Nome = txtNomeFunc.Text;
            f.RG = mtbRgFunc.Text;
            f.DataNascimento = Convert.ToDateTime(dtpDataNascFunc);

            //verifica a opção do sexo selecionada
            if (rbtnMasculinoFunc.Checked == true)
            {
                f.Sexo = "Masculino";
            }
            else if (rbtnFemininoFunc.Checked == true)
            {
                f.Sexo = "Feminino";
            }
            else if (rbtnNInformadoFunc.Checked == true)
            {
                f.Sexo = "Não Informado";
            }

            f.Email = txtEmailFunc.Text;


            return f;
        }

       
        private void btnExibirTodosFunc_Click(object sender, System.EventArgs e)
        {
            dgvExibeFunc.Rows.Clear(); //limpa o datagrid

            /*
            foreach (KeyValuePair<long, Funcionario> linha in Banco.dicFunc)
            {
                dgvExibeFunc.Rows.Add(linha.Key, linha.Value.Nome);

            }
            */
            

            
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

        private void btnEditarFunc_Click(object sender, System.EventArgs e)
        {
            //pega a linha no dataGrid selecionada e abre a telaCadastro de funcionário já setados para alteração
            DialogResult edit = MessageBox.Show("Deseja editar o Funcionário selecionado?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (edit == DialogResult.Yes)
            {
                abasGerFuncionario.SelectedTab = abaCadFuncionario;

                //seta os dados do funcionario selecionado na tela de cadastro
            }
        }

        private void btnExcluirFunc_Click(object sender, System.EventArgs e)
        {
            DialogResult rm = MessageBox.Show("Deseja remover o Cliente selecionado?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rm == DialogResult.Yes)
            {
                MessageBox.Show("Cliente removido com Sucesso");
            }
        }

        private void txtSalarioBaseFunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            //força o campo a receber apenas numeros (estilo monetários)
            ClasseUtil.somenteValores(txtSalarioBaseFunc, e);

            
        }
    }
}
