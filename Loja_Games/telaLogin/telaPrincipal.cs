﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja_games;

namespace telaLogin
{
    public partial class telaPrincipal : Form
    {
        public telaPrincipal()
        {
            InitializeComponent();
        }

        private void btnJogos_Click(object sender, EventArgs e)
        {
            telaJogos jogos = new telaJogos();

            jogos.Show();

        }
    }
}
