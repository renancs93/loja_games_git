using System;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaCadastroCliente : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form telaP = null;

        public telaCadastroCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            string MensagemErro = "";

            MensagemErro = ClasseUtil.ValidaCampos(Controls);
            
            if(MensagemErro == "")
            {
                MessageBox.Show("Cliente Cadastrado com Sucesso!");
                telaP.Show();
                Close();
            }
            else
            {
                MessageBox.Show(MensagemErro);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult sair = MessageBox.Show("Os dados serão perdidos!\nDeseja realmente Sair?", "Sair" ,MessageBoxButtons.YesNo ,MessageBoxIcon.Question);

            
            if(sair == DialogResult.Yes)
            {
                telaP.Show();//exibi a telaPrincipal setada no metodo setTelaPrincipal desse form
                Close();//fecha esse form
            }
            

        }

        public void setTelaAnterior(System.Windows.Forms.Form t)
        {
            telaP = t;
        }

        private void telaCadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            telaP.Show();
        }

        private void mtbCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas dígitos de 0 a 9 são aceitos neste campo.\n\n" +
             "Você está tentando inserir um caractere inválido ");
        }

        private void mtbRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
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
    }
}
