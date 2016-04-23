using System;
using System.Data;
using System.Windows.Forms;

namespace Loja_games
{
    public partial class telaJogos : Form
    {
        public telaJogos()
        {
            InitializeComponent();

        }

        private void telaJogos_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {
            if (txtCampoBusca.Text == String.Empty)
            {
                MessageBox.Show("Campo de Nome vazio");
            }
            else
            {
                dGridResultado.ClearSelection();

                //adicionar dados do banco

            }


        }

        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            dGridResultado.ClearSelection();

            //adicionar dados do banco

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}
