using System;
using System.Linq;
using System.Windows.Forms;

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

        }

        private void btnRemAlug_Click(object sender, EventArgs e)
        {
            DialogResult RmItem = MessageBox.Show("Deseja realmente remover o item?", "Aluguel", MessageBoxButtons.YesNo);

            if (RmItem == DialogResult.Yes)
            {
                MessageBox.Show("Item Removido!");
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

        private void txtValorParcela_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorParcela.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtTotalCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtTotalCompra.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtTotalAluguel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtTotalAluguel.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtCodigoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtCodigoFuncionario.Text.Contains(','))
                    {
                        e.KeyChar = (Char)0;
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtCodigoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtCodigoProduto.Text.Contains(','))
                    {
                        e.KeyChar = (Char)0;
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtProdAlug_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtProdAlug.Text.Contains(','))
                    {
                        e.KeyChar = (Char)0;
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtFuncAlug_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
              (e.KeyChar != ',' && e.KeyChar != '.' &&
               e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtFuncAlug.Text.Contains(','))
                    {
                        e.KeyChar = (Char)0;
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }
    }
}
