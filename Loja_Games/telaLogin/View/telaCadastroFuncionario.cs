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
    public partial class telaCadastroFuncionario : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form telaP = null;

        public telaCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult cancel = MessageBox.Show("Os dados serão perdidos! \n Deseja mesmo sair da tela de cadastro? ", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(cancel == DialogResult.Yes)
            {
                Close();
                telaP.Show();
            }
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //realizar as verificações dos campos antes de cadastrar
            string MensagemErro = "";

            MensagemErro = ClasseUtil.ValidaCampos(Controls);

            if(MensagemErro == "")
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!");
                Close();
                telaP.Show();
            }
            else
            {
                MessageBox.Show(MensagemErro);
            }

            
            
        }

        public void setTelaAnterior(System.Windows.Forms.Form t)
        {
            telaP = t;
        }

        private void telaCadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
        {

            Dispose();
            telaP.Show();
        }

        private void telaCadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
