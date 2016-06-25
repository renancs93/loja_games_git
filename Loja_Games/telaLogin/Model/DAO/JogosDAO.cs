using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaGames.Classes;
using MySql.Data.MySqlClient;

namespace LojaGames.Model.DAO
{
    class JogosDAO
    {
        public void Create(Jogos j)
        {
            Banco dbGames = Banco.GetInstance();

            string qry = "INSERT INTO jogos (codigo_jogo, nome, preco, console, genero, qnt_estoque, lancamento)"
                       + " VALUES (@cod, @nome, @preco, @console, @genero, @qnt_estoque, @lancamento)";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.Add("@cod", MySqlDbType.Int32);
            comm.Parameters.Add("@nome", MySqlDbType.String);
            comm.Parameters.Add("@preco", MySqlDbType.Float);
            comm.Parameters.Add("@console", MySqlDbType.String);
            comm.Parameters.Add("@genero", MySqlDbType.String);
            comm.Parameters.Add("@qnt_estoque", MySqlDbType.Int32);
            comm.Parameters.Add("@lancamento", MySqlDbType.DateTime);

            comm.Parameters["@cod"].Value = j.Codigo;
            comm.Parameters["@nome"].Value = j.Nome;
            comm.Parameters["@preco"].Value = j.Preco;
            comm.Parameters["@console"].Value = j.Console;
            comm.Parameters["@genero"].Value = j.Genero;
            comm.Parameters["@qnt_estoque"].Value = j.QntEstoque;
            comm.Parameters["@lancamento"].Value = j.Lancamento;

            dbGames.ExecuteSQL_NonQuery(comm);
        }

        public DataTable ListAll_Jogos()
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtJogos = new DataTable();

            string qry = "SELECT j.codigo_jogo as Codigo, j.nome as Nome, j.preco as Preço, j.console as Console, j.genero as Genero, j.qnt_estoque as Quantidade_Estoque, j.lancamento as Lançamento"
                       + " FROM jogos j";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtJogos);

            conexao.Close();
            return dtJogos;

        }

        public int max_cod_jogo()
        {
            int max;

            //MySqlConnection conexao = Banco.GetInstance().GetConnection();
            Banco conexao = Banco.GetInstance();

            string qry = "SELECT MAX(codigo_jogo) from jogos";

            MySqlCommand comm = new MySqlCommand(qry);

            max = conexao.ExecuteSQL_Scalar(comm);

            if(max == null)
            {
                max = 0;
            }

            return max;
        }

        public DataTable buscaPorNomeJogo(string nomeJogo)
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtJogos = new DataTable();

            string qry = "SELECT j.codigo_jogo as Codigo, j.nome as Nome, j.preco as Preço, j.console as Console, j.genero as Genero, j.qnt_estoque as Quantidade_Estoque, j.lancamento as Lançamento"
                       + " FROM jogos j WHERE j.nome LIKE '%"+nomeJogo+"%'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtJogos);

            conexao.Close();
            return dtJogos;
        }

        public DataTable buscaPorConsoleJogo(string console)
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtJogos = new DataTable();

            string qry = "SELECT j.codigo_jogo as Codigo, j.nome as Nome, j.preco as Preço, j.console as Console, j.genero as Genero, j.qnt_estoque as Quantidade_Estoque, j.lancamento as Lançamento"
                       + " FROM jogos j WHERE j.console = '"+ console + "'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtJogos);

            conexao.Close();
            return dtJogos;
        }

        public DataTable buscaPorGeneroJogo(string genero)
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtJogos = new DataTable();

            string qry = "SELECT j.codigo_jogo as Codigo, j.nome as Nome, j.preco as Preço, j.console as Console, j.genero as Genero, j.qnt_estoque as Quantidade_Estoque, j.lancamento as Lançamento"
                       + " FROM jogos j WHERE j.genero  = '" + genero + "'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtJogos);

            conexao.Close();
            return dtJogos;
        }

        public Jogos Read(int cod)
        {
            Jogos jogo = new Jogos();
            MySqlConnection conexao = Banco.GetInstance().GetConnection();

            string qry = "SELECT * FROM jogos WHERE codigo_jogo = " + cod + "";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {

                jogo.Nome = dr.GetString("nome");
                jogo.Codigo = dr.GetInt32("codigo_jogo");
                jogo.Preco = dr.GetFloat("preco");
                jogo.Console = dr.GetString("console");
                jogo.Genero = dr.GetString("genero");
                jogo.QntEstoque  = dr.GetInt32("qnt_estoque");
                jogo.Lancamento = dr.GetDateTime("lancamento");

            }

            conexao.Close();
            return jogo;
        }

        public void Update(Jogos j)
        {
            Banco dbGames = Banco.GetInstance();

            int codigo = j.Codigo;

            string qry = "UPDATE jogos SET nome = @nome, preco = @preco, console = @console, genero = @genero, qnt_estoque = @qnt_estoque, lancamento = @lancamento" 
                       + " WHERE codigo_jogo = "+codigo+"";

            MySqlCommand comm = new MySqlCommand(qry);

            //relaciona os parametros do SQL e o tipo do dado
            //comm.Parameters.Add("@cod", MySqlDbType.Int32);
            comm.Parameters.Add("@nome", MySqlDbType.String);
            comm.Parameters.Add("@preco", MySqlDbType.Float);
            comm.Parameters.Add("@console", MySqlDbType.String);
            comm.Parameters.Add("@genero", MySqlDbType.String);
            comm.Parameters.Add("@qnt_estoque", MySqlDbType.Int32);
            comm.Parameters.Add("@lancamento", MySqlDbType.DateTime);

            //seta nos paramentros os dados do objeto passado
            //comm.Parameters["@cod"].Value = j.Codigo;
            comm.Parameters["@nome"].Value = j.Nome;
            comm.Parameters["@preco"].Value = j.Preco;
            comm.Parameters["@console"].Value = j.Console;
            comm.Parameters["@genero"].Value = j.Genero;
            comm.Parameters["@qnt_estoque"].Value = j.QntEstoque;
            comm.Parameters["@lancamento"].Value = j.Lancamento;

            //chama o metodo da classe Banco passando o comando e os dados para execução
            dbGames.ExecuteSQL_NonQuery(comm);
        }

        public void Delete(int codigo)
        {
            Banco dbGames = Banco.GetInstance();

            string qry = "DELETE FROM jogos WHERE codigo_jogo = @codigo";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.Add("@codigo", MySqlDbType.Int32);

            comm.Parameters["@codigo"].Value = codigo;

            dbGames.ExecuteSQL_NonQuery(comm);
        }


    }
}
