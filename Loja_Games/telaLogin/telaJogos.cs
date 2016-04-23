using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Loja_games
{
    public partial class telaJogos : Form
    {
        //add banco de dados;
        private MySqlConnection mConn;
        private MySqlDataAdapter mAdapter;
        private DataSet mDatSet;

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

                /*
                dataGridView1.ClearSelection();
                //define o dataset
                mDatSet = new DataSet();

                //define a string de conexão e cria a conexão
                mConn = new MySqlConnection(@"server=localhost; user id=root; password=cafess123; database=bicicletaria");
                mConn.Open();

                //verifica se a conexão esta aberta
                if (mConn.State == ConnectionState.Open)
                {
                    string busca = txtCampoBusca.Text;

                    //instrução sql
                    mAdapter = new MySqlDataAdapter("Select * from produto where cod_prod="+busca, mConn);

                    //preenche os dados atraves do adapter
                    mAdapter.Fill(mDatSet, "Produto");

                    //add o resultado no DataGrid
                    dataGridView1.DataSource = mDatSet;
                    dataGridView1.DataMember = "Produto";


                }
                */
            }


        }

        private void btnExibirTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            
            /*
            //define o dataset
            mDatSet = new DataSet();

            //define a string de conexão e cria a conexão
            mConn = new MySqlConnection(@"server=localhost; user id=root; password=cafess123; database=bicicletaria");
            mConn.Open();

            //verifica se a conexão esta aberta
            if (mConn.State == ConnectionState.Open)
            {
                //instrução sql
                mAdapter = new MySqlDataAdapter("Select * from produto", mConn);

                //preenche os dados atraves do adapter
                mAdapter.Fill(mDatSet, "Produto");

                //add o resultado no DataGrid
                dataGridView1.DataSource = mDatSet;
                dataGridView1.DataMember = "Produto";
            }
            */
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            mConn.Close();
            Close();
        }
    }
}
