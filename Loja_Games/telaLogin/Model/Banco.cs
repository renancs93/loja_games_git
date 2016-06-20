﻿using System.Collections.Generic;
using LojaGames.Classes;
using MySql.Data.MySqlClient;


namespace LojaGames.Model
{
    class Banco
    {
        private static MySqlConnection conexao;
        private static Banco instance;

        //Conexões
        //private const string URL = "Server=sql8.freemysqlhosting.net; Port=3306; Database=sql8122133; Uid=sql8122133; Pwd=9wYweNm9rc;";
        private const string URL = "Server=localhost;Database=games;Uid=root;Pwd=cafess123;";

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
            comando.Connection = conexao;
            
                if (conexao.State != System.Data.ConnectionState.Open)
                    conexao.Open();

                comando.ExecuteNonQuery();
            
                conexao.Close();
            
        }

       
    }
}
