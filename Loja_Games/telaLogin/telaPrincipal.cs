using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            barraProgresso.Value = 0;
            while (barraProgresso.Value < 100)
            {
                Thread.Sleep(20);
                barraProgresso.Value = barraProgresso.Value + 1;
            }
                telaJogos jogos = new telaJogos();
                jogos.Show();
            
        }

        
    }
}
