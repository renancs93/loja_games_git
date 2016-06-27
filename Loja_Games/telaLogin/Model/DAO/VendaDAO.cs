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
        int codigo;

        public int max_cod_venda()
        {
            int total;

            Banco conexao = Banco.GetInstance();

            string qry = "SELECT MAX(codigo_venda) from venda";

            MySqlCommand comm = new MySqlCommand(qry);
            
            total = conexao.ExecuteSQL_Scalar_int(comm);
            
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

            string qry = "INSERT INTO venda(codigo_venda, cpf_cli, cpf_func, cod_jogo, quantidade, valor_total, pagamento)"
                        + "VALUES (@codigo_venda, @cpf_cli, @cpf_func, @cod_jogo, @quantidade, @valor_total, @pagamento)";

            MySqlCommand comm = new MySqlCommand(qry);

            //relaciona os parametros do SQL e o tipo do dado
            comm.Parameters.Add("@codigo_venda", MySqlDbType.Int32);
            comm.Parameters.Add("@cpf_cli", MySqlDbType.String);
            comm.Parameters.Add("@cpf_func", MySqlDbType.String);
            comm.Parameters.Add("@cod_jogo", MySqlDbType.Int32);
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32);
            comm.Parameters.Add("@valor_total", MySqlDbType.Float);
            comm.Parameters.Add("@pagamento", MySqlDbType.String);

            //seta nos paramentros os dados do objeto passado
            comm.Parameters["@codigo_venda"].Value = v.CodigoVenda;
            comm.Parameters["@cpf_cli"].Value = v.CPF_Cliente;
            comm.Parameters["@cpf_func"].Value = v.CPF_Funcionario;
            comm.Parameters["@cod_jogo"].Value = v.CodJogos;
            comm.Parameters["@quantidade"].Value = v.Quantidade;
            comm.Parameters["@valor_total"].Value = v.Total;
            comm.Parameters["@pagamento"].Value = v.Pagamento;

            //chamada para execução do SQL na tabela Pessoa
            dbGames.ExecuteSQL_NonQuery(comm);

        }
    }
}
