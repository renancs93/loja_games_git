using System;
using System.Linq;
using System.Windows.Forms;
using LojaGames.Classes;
using LojaGames.Controller;

namespace LojaGames
{
    public partial class telaJogos : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Form TelaP = null;
        //double valor;
        JogosBanco jogosBanco = new JogosBanco();

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
            dGridResultado.DataSource = jogosBanco.ExibirTodosJogos();
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
            ClasseUtil.LimparCampos(abaExibeJogos.Controls);
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
            string mensagemErro = "";

            mensagemErro = ClasseUtil.ValidaCampos(abaCadastraJogos.Controls);

            if (mensagemErro == "")
            {
                if (btnCadastrar.Text == "Cadastrar")
                {
                    DialogResult confirma = MessageBox.Show("Deseja Cadastrar o Jogo?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirma == DialogResult.Yes)
                    {
                        jogosBanco.CadastraJogo(povoaJogo());

                        MessageBox.Show("Cadastrado com Sucesso!");
                        
                    }
                    else if (confirma == DialogResult.No)
                    {
                        MessageBox.Show("Jogo não Cadastrado!");
                    }
                    ClasseUtil.LimparCampos(abaCadastraJogos.Controls);
                }

                if (btnCadastrar.Text == "Salvar")
                {
                    DialogResult Confirmar = MessageBox.Show("As informações do Jogo serão alteradas!\nDeseja realmente salvar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    //chama o metodo da classe útil e valida se os campos (textBox) estão preenchido

                    if (Confirmar == DialogResult.Yes)
                    {
                            //Salvar no banco


                            MessageBox.Show("Jogo alterado com Sucesso!");

                            //restaurar tela e voltar para aba de exibição de jogos
                            btnCadastrar.Enabled = true;
                            ClasseUtil.LimparCampos(abaCadastraJogos.Controls);

                            btnCadastrar.Text = "Cadastrar";
                            paginaAbasJogos.SelectTab(abaExibeJogos);
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
            else
            {
                MessageBox.Show(mensagemErro);
            }

            lbCodigoNumero.Text = (1 + jogosBanco.gerar_codigo_Jogo()).ToString();

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
            lbCodigoNumero.Text = (1 + jogosBanco.gerar_codigo_Jogo()).ToString();
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

        private Jogos povoaJogo()
        {
            Jogos jogo = new Jogos();

            jogo.Codigo = Convert.ToInt32(lbCodigoNumero.Text);
            jogo.Nome = txtNome.Text;
            jogo.Preco = float.Parse(txtPreco.Text);

            if (rbtnXbox.Checked == true)
            {
                jogo.Console = "XBOX ONE";
            }
            else if (rbtnPS4.Checked == true)
            {
                jogo.Console = "PS4";
            }
            else
            {
                jogo.Console = "PC";
            }

            jogo.Genero = cbxGeneroCad.Text;
            jogo.QntEstoque = Convert.ToInt32(numQuantidade.Value);

            jogo.Lancamento = Convert.ToDateTime(dtpDataLancamento.Text);

            return jogo;
        }


    }
    
}
