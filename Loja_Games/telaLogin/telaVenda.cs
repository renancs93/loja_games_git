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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {

        }

        private void gbpDadoVenda_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblCodigoProduto_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lvlJurAlug_Click(object sender, EventArgs e)
        {

        }

        //Metodo para a TelaPrincipal
        public void getTelaPrincipal(telaPrincipal t)
        {
            telaP = t;
        }
        
        //evento ao clicar no X da tela
        private void telaVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            telaP.Show();
            Dispose();
        }
    }
}
