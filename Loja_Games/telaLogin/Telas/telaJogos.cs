﻿using System;
using System.Data;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaJogos : Form
    {
        private telaPrincipal TelaP = null; 

        public telaJogos()
        {
            InitializeComponent();

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
            TelaP.Show();
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCampoBusca.Text = "";

            //verifica se algumas da opcoes do radioButom (consoles) estão ativas e remove a seleção
            if((rbtnPS4.Checked || rbtnXbox.Checked || rbtnPc.Checked) == true)
            {
                rbtnPS4.Checked = false;
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

        public void getTelaPrincipal(telaPrincipal t)
        {
            TelaP = t;
        }

        private void telaJogos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            TelaP.Show();
        }
    }
    
}
