using System;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaVenda : Form
    {
        private telaPrincipal telaP = null;

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

            MessageBox.Show("Produto adicionado na lista!", "Venda");
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            //Esse botão terá que remover um item da lista de compra do cliente

            DialogResult RmItem = MessageBox.Show("Deseja realmente remover o item?", "Venda", MessageBoxButtons.YesNo);

            if (RmItem == DialogResult.Yes)
            {
                MessageBox.Show("Item Removido!");
            }


        }

        //Metodo para a TelaPrincipal
        public void getTelaPrincipal(telaPrincipal t)
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

        }

        private void btnRemAlug_Click(object sender, EventArgs e)
        {
            DialogResult RmItem = MessageBox.Show("Deseja realmente remover o item?", "Aluguel", MessageBoxButtons.YesNo);

            if (RmItem == DialogResult.Yes)
            {
                MessageBox.Show("Item Removido!");
            }

        }
    }
}
