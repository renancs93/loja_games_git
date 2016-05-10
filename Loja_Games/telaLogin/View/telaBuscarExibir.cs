using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaBuscarExibir : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form telaP = null;

        public telaBuscarExibir()
        {
            InitializeComponent();
        }

        public void setTelaAnterior(System.Windows.Forms.Form t)
        {
            telaP = t;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            telaP.Show();
        }

        private void telaBuscarExibir_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCliente.Text;
            string cpf = mtbCPFCliente.Text;

            if((nome == string.Empty) && (cpf == string.Empty))
            {
                MessageBox.Show("O Campo CPF ou Campo Nome devem ser preenchido!");
            }
            else
            {
                //irá realizar a busca de acordo com os dados fornecido em uns dos campos
                //caso não encontrado nenhum valor no banco correspondente exibir mensagem e mostrar todos
                
            }

        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            //pega a linha no dataGrid selecionada e abre a telaCadastro de cliente já setados para alteração

            DialogResult edit = MessageBox.Show("Deseja editar o Funcionário selecionado?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (edit == DialogResult.Yes)
            {
                telaCadastroCliente editarCliente = new telaCadastroCliente();
                editarCliente.setTelaAnterior(this);

                editarCliente.Show();

                Hide();
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult rm = MessageBox.Show("Deseja remover o Cliente selecionado?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rm == DialogResult.Yes)
            {
                MessageBox.Show("Cliente removido com Sucesso");
            }

        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            string nome = txtNomeFuncionario.Text;
            string cpf = mtbCPFFuncionario.Text;

            if ((nome == string.Empty) && (cpf == string.Empty))
            {
                MessageBox.Show("O Campo CPF ou Campo Nome devem ser preenchido!");
            }
            else
            {
                //irá realizar a busca de acordo com os dados fornecido em uns dos campos
                //caso não encontrado nenhum valor no banco correspondente exibir mensagem e mostrar todos

            }

        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            //Deve confirmar e remover o funcionário na qual a linha no dataGrid está selecionada
            DialogResult rm = MessageBox.Show("Deseja remover o Funcionário selecionado?", "Remover", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(rm == DialogResult.Yes)
            {
                MessageBox.Show("Funcionário removido com Sucesso");
            }


        }

        private void btnEditarFuncionario_Click(object sender, EventArgs e)
        {
            //pega a linha no dataGrid selecionada e abre a telaCadastro de funcionário já setados para alteração

            DialogResult edit = MessageBox.Show("Deseja editar o Funcionário selecionado?", "Editar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (edit == DialogResult.Yes)
            {
                telaCadastroFuncionario editarFunc = new telaCadastroFuncionario();
                editarFunc.setTelaAnterior(this);
                editarFunc.Show();
                Hide();
            }


        }

        private void telaBuscarExibir_Load(object sender, EventArgs e)
        {

        }

        private void mtbCPFCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas dígitos de 0 a 9 são aceitos neste campo.\n\n" +
             "Você está tentando inserir um caractere inválido ");
        }
    }
}
