using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LojaGames.Classes;
using MySql.Data.MySqlClient;


namespace LojaGames.Model
{
    class Banco
    {
        private static MySqlConnection conexao;
        private static Banco instance;

        //Conexões server
        //private const string URL = "Server=sql8.freemysqlhosting.net; Port=3306; Database=sql8122133; Uid=sql8122133; Pwd=9wYweNm9rc;";
        private const string URL = "Server=sql6.freemysqlhosting.net; Port=3306; Database=sql6125738; Uid=sql6125738; Pwd=z7alel5IHI;";

        //conexão Local
        //private const string URL = "Server=localhost;Database=games;Uid=root;Pwd=cafess123;";
        //private const string URL = "Server=localhost;Database=loja_games;Uid=root;Pwd=1234;";

        private Banco()
        {
            conexao = new MySqlConnection(URL);
        }

        public static Banco GetInstance()
        {
            if (instance == null)
                instance = new Banco();
            return instance;
        }

        public MySqlConnection GetConnection()
        {
            return conexao;
        }

        public void ExecuteSQL_NonQuery(MySqlCommand comando)
        {
            try
            {


                comando.Connection = conexao;

                if (conexao.State != System.Data.ConnectionState.Open)
                    conexao.Open();

                comando.ExecuteNonQuery();

                conexao.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public int ExecuteSQL_Scalar_int(MySqlCommand comando)
        {
            comando.Connection = conexao;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            int resultado = Convert.ToInt32(comando.ExecuteScalar());
            
            conexao.Close();
            return resultado;
        }

        public string ExecuteSQL_Scalar_string(MySqlCommand comando)
        {
            comando.Connection = conexao;

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            string texto = Convert.ToString(comando.ExecuteScalar());

            conexao.Close();
            return texto;
        }

    }
}
