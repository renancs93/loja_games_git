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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCampoBusca.Text = "";

            //verifica se algumas da opcoes do radioButom (consoles) estão ativas e remove a seleção
            if((rbtnPSP.Checked || rbtnXbox.Checked || rbtnPc.Checked) == true)
            {
                rbtnPSP.Checked = false;
                rbtnXbox.Checked = false;
                rbtnPc.Checked = false;
            }

            //remove as seleções dos combobox de gênero
            cboxAcaoAventura.Checked = false;
            cboxCorrida.Checked = false;
            cboxEsportes.Checked = false;
            cboxEstrategia.Checked = false;
            cboxLuta.Checked = false;
            cboxMusicalRitmico.Checked = false;
            cboxPlataforma.Checked = false;
            cboxPuzzle.Checked = false;
            cboxRpg.Checked = false;
            cboxTiro.Checked = false;

        }
    }
    
}
