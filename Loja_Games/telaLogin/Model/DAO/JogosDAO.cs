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
                max = 1;
            }

            return max;
        }



    }
}
