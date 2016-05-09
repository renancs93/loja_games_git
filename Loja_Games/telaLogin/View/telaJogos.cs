using System;
using System.Data;
using System.Windows.Forms;

namespace LojaGames
{
    public partial class telaJogos : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form TelaP = null; 

        public telaJogos()
        {
            InitializeComponent();

        }

        private void btnBuscarNome_Click(object sender, EventArgs e)
        {
            if (txtCampoBusca.Text == string.Empty)
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
            DialogResult Confirmar = MessageBox.Show("As informações do Jogo serão alteradas!\nDeseja realmente salvar?", "Confirmar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if(Confirmar == DialogResult.Yes)
            {
                //salvar as aterações no jogo e voltar para aba de exibição de jogos
                btnCadastrar.Enabled = true;
                MessageBox.Show("Jogo alterado com Sucesso!");
            
                paginaAbasJogos.SelectTab(abaExibeJogos);

            }
            else if(Confirmar == DialogResult.No)
            {
                //Não fazer nada e voltar para aba de exibição de jogos
                btnCadastrar.Enabled = true;
                MessageBox.Show("Nenhuma informação do jogo foi alterada!");

                paginaAbasJogos.SelectTab(abaExibeJogos);

                
            }


        }

        private void btnBuscarTipo_Click(object sender, EventArgs e)
        {
            
            if((rbtnPS4.Checked || rbtnXbox.Checked || rbtnPc.Checked)== true)
            {

            }
            else
            {
                MessageBox.Show("Você deve escolher qual é o Tipo de Video-Game");
            }
            
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e) //mostrar para o grupo
        {
            string mensagemErro = ClasseUtil.ValidaCampos(Controls);


            DialogResult salvar = MessageBox.Show("Deseja Cadastrar o Jogo?", "Salvar",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            if(salvar == DialogResult.Yes)
            {
                if(mensagemErro == "")
                    MessageBox.Show("Cadastrado com Sucesso!");
                else
                    MessageBox.Show(mensagemErro);
            }
            else if(salvar == DialogResult.No)
            {
                MessageBox.Show("Jogo não salvo!");
            }
        }

        //irá setar abrir a aba de cadastro jogo com os dados setados nos campos do jogo na qual a linha no dataGrid estiver selecionada.
        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnAlteracoes.Enabled = true;
            btnCadastrar.Enabled = false;
    
            //muda para outra aba de cadastra jogo
            paginaAbasJogos.SelectTab(abaCadastraJogos);
            
            


        }

        private void telaJogos_Load(object sender, EventArgs e)
        {
            //padroniza a ativação dos botões ao carregar a tela
            btnCadastrar.Enabled = true;
            btnAlteracoes.Enabled = false;
        }

        private void mtbPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Apenas digitos de 0 a 9 são aceitos neste campo. \n\n" +
                "Você está tentando inserir um caractere inválido. ");
        }
    }
    
}
