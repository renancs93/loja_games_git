﻿using System.Windows.Forms;

namespace LojaGames.View
{
    public partial class telaGerCliente : Form
    {
        private Form telaP = null;

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
            //pega a linha no dataGrid selecionada e abre a telaCadastro de Cliente já setados para alteração
            DialogResult edit = MessageBox.Show("Deseja editar o Cliente selecionado?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (edit == DialogResult.Yes)
            {
                abasGerCliente.SelectedTab = abaCadCliente;

                //seta os dados do Cliente selecionado na tela de cadastro
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



                DialogResult cadastrado = MessageBox.Show("Cliente cadastrado com sucesso.", "Cadastrado!", MessageBoxButtons.OK, MessageBoxIcon.None);
                //Close();
                //telaP.Show();
            }
            else
            {
                DialogResult alerta = MessageBox.Show(MensagemErro, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }
    }
}
