using System;
using System.Linq;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaJogos : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form TelaP = null;
        double valor;

        public telaJogos()
        {
            InitializeComponent();

        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {
            if (txtCampoBusca.Text == string.Empty)
            {
                DialogResult busca = MessageBox.Show("Campo de nome vazio!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
            DialogResult sair = MessageBox.Show("Deseja Sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(sair == DialogResult.Yes)
            {
                Close();
                TelaP.Show();
            }
            

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

        public void setTelaAnterior(System.Windows.Forms.Form t)
        {
            TelaP = t;
        }

        private void telaJogos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
            TelaP.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult Cancelar = MessageBox.Show("Os dados serão perdidos!\nDeseja realmente Cancelar?","Cancelar",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(Cancelar == DialogResult.Yes)
            {
                Close();
                TelaP.Show();
            }
                        
        }

        private void btnAlteracoes_Click(object sender, EventArgs e)
        {
            


        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            
            if((rbtnPS4.Checked || rbtnXbox.Checked || rbtnPc.Checked)== true)
            {

            }
            else
            {
                DialogResult buscar = MessageBox.Show("Você deve escolher qual é o tipo de Vídeo Game!", "Busca", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e) //mostrar para o grupo
        {
            string mensagemErro = ClasseUtil.ValidaCampos(abaCadastraJogos.Controls);

            if (btnCadastrar.Text == "Cadastrar")
            {
                DialogResult salvar = MessageBox.Show("Deseja Cadastrar o Jogo?", "Salvar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (salvar == DialogResult.Yes)
                {
                    if (mensagemErro == "")
                    {
                        MessageBox.Show("Cadastrado com Sucesso!");
                        txtNome.Text = "";
                        txtPreco.Text = "";
                        numQuantidade.Value = 0;
                        rbPS4.Checked = false;
                        rbXBOX.Checked = false;
                        rbPC.Checked = false;
                        ckbAcao.Checked = false;
                        ckbEsportes.Checked = false;
                        ckbEstrategia.Checked = false;
                        ckbLuta.Checked = false;
                        ckbMusical.Checked = false;
                        ckbPlataforma.Checked = false;
                        ckbPuzzle.Checked = false;
                        ckbRPG.Checked = false;
                        ckbTiro.Checked = false;
                    }
                    else
                        MessageBox.Show(mensagemErro);
                }
                else if (salvar == DialogResult.No)
                {
                    MessageBox.Show("Jogo não salvo!");
                }
            }

            if(btnCadastrar.Text == "Salvar")
            {
                DialogResult Confirmar = MessageBox.Show("As informações do Jogo serão alteradas!\nDeseja realmente salvar?", "Confirmar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                //chama o metodo da classe útil e valida se os campos (textBox) estão preenchido
                
                if (Confirmar == DialogResult.Yes)
                {
                    if (mensagemErro == "")
                    {
                        //salvar as aterações no jogo e voltar para aba de exibição de jogos
                        btnCadastrar.Enabled = true;
                        MessageBox.Show("Jogo alterado com Sucesso!");
                        txtNome.Text = "";
                        txtPreco.Text = "";
                        numQuantidade.Value = 0;
                        rbPS4.Checked = false;
                        rbXBOX.Checked = false;
                        rbPC.Checked = false;
                        ckbAcao.Checked = false;
                        ckbEsportes.Checked = false;
                        ckbEstrategia.Checked = false;
                        ckbLuta.Checked = false;
                        ckbMusical.Checked = false;
                        ckbPlataforma.Checked = false;
                        ckbPuzzle.Checked = false;
                        ckbRPG.Checked = false;
                        ckbTiro.Checked = false;

                        btnCadastrar.Text = "Cadastrar";
                        paginaAbasJogos.SelectTab(abaExibeJogos);


                    }
                    else
                    {
                        MessageBox.Show(mensagemErro);
                    }

                }
                else if (Confirmar == DialogResult.No)
                {
                    //Não fazer nada e voltar para aba de exibição de jogos
                    MessageBox.Show("Nenhuma informação do jogo foi alterada!");

                    paginaAbasJogos.SelectTab(abaExibeJogos);
                    btnCadastrar.Text = "Cadastrar";

                }
            }

        }

        //irá setar abrir a aba de cadastro jogo com os dados setados nos campos do jogo na qual a linha no dataGrid estiver selecionada.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Salvar";

            //muda para outra aba de cadastra jogo
            paginaAbasJogos.SelectTab(abaCadastraJogos);

            
        }

        private void telaJogos_Load(object sender, EventArgs e)
        {
            
        }

        private void mtbPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas digitos de 0 a 9 são aceitos neste campo. \n\n" +
                "Você está tentando inserir um caractere inválido. ");
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            //força o campo a receber apenas numeros (estilo monetários)
            ClasseUtil.somenteValores(txtPreco, e);

        }
    }
    
}
