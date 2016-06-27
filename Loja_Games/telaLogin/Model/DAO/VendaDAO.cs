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
    class VendaDAO
    {
        public int max_cod_venda()
        {
            int total;

            //MySqlConnection conexao = Banco.GetInstance().GetConnection();
            Banco conexao = Banco.GetInstance();

            string qry = "SELECT MAX(codigo_venda) from venda";

            MySqlCommand comm = new MySqlCommand(qry);

            
            total = conexao.ExecuteSQL_Scalar_int(comm);

            if (total == null)
            {
                total = 0;
            }

            return total;
        }

        public DataTable tiposPagamento()
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dt = new DataTable();

            string qry = "SELECT tipo FROM pagamento ORDER BY tipo";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dt);

            conexao.Close();
            return dt;
        }

        public void Create(Venda v)
        {
            Banco dbGames = Banco.GetInstance();
            //MySqlConnection conexao = Banco.GetInstance().GetConnection();

            string qry = "INSERT INTO venda(codigo_venda, cpf_cli, cpf_func, cod_jogo, cod_pagamento, quantidade, numero_parcelas, valor_parcelas, valor_total)"
                        + "VALUES (@cod_venda, @cpf_cli, @cpf_func, @cod_jogo, @cod_pagamento, @qnt, @num_parcelas, @valor_total)";

            MySqlCommand comm = new MySqlCommand(qry);

            //relaciona os parametros do SQL e o tipo do dado
            comm.Parameters.Add("@cod_venda", MySqlDbType.Int32);
            comm.Parameters.Add("@cpf_cli", MySqlDbType.Int64);
            comm.Parameters.Add("@cpf_func", MySqlDbType.Int32);
            comm.Parameters.Add("@cod_jogo", MySqlDbType.Int32);
            comm.Parameters.Add("@cod_pagamento", MySqlDbType.Int32);
            comm.Parameters.Add("@qnt", MySqlDbType.Int32);
            comm.Parameters.Add("@num_parcelas", MySqlDbType.Int32);
            comm.Parameters.Add("@valor_parcelas", MySqlDbType.Float);
            comm.Parameters.Add("@valor_total", MySqlDbType.Float);

            //seta nos paramentros os dados do objeto passado
            comm.Parameters["@cod_venda"].Value = v.CodigoVenda;
            comm.Parameters["@cpf_cli"].Value = v.Cliente.CPF;
            comm.Parameters["@cpf_func"].Value = v.Funcionario.CPF;
            comm.Parameters["@cod_jogo"].Value = v.Jogos.Codigo;
            comm.Parameters["@cod_pagamento"].Value = v.Pagamento.Codigo_pagamento;
            comm.Parameters["@qnt"].Value = v.Quantidade;
            comm.Parameters["@num_parcelas"].Value = v.NumeroParcelas;
            comm.Parameters["@valor_parcelas"].Value = v.ValorParcelas;
            comm.Parameters["@valor_total"].Value = v.Total;

            //chamada para execução do SQL na tabela Pessoa
            dbGames.ExecuteSQL_NonQuery(comm);

        }

    }
}
