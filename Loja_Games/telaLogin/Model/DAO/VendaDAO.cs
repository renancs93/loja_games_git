using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (total == null || total == System.Convert.ToInt32(string.Empty))
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
        

    }
}
