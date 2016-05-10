using System;
using System.Linq;
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

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas dígitos de 0 a 9 são aceitos neste campo.\n\n" +
             "Você está tentando inserir um caractere inválido ");
        }

        private void mtbTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas dígitos de 0 a 9 são aceitos neste campo.\n\n" +
             "Você está tentando inserir um caractere inválido ");
        }

        private void mtbCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas dígitos de 0 a 9 são aceitos neste campo.\n\n" +
             "Você está tentando inserir um caractere inválido ");
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtNumero.Text.Contains(','))
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

        private void txtSalarioBase_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!txtSalarioBase.Text.Contains(','))
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
    }
}
