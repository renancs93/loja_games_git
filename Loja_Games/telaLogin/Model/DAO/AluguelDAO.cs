using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaGames.Model.DAO
{
    class AluguelDAO
    {
        public void Create(Aluguel a)
        {
            Banco dbGames = Banco.GetInstance();

            string qry = "INSERT INTO aluguel(codigo_aluguel, cpf_cli, cpf_func, cod_jogo, dias_aluguel, valor_total, pagamento)"
                        + "VALUES (@codigo_aluguel, @cpf_cli, @cpf_func, @cod_jogo, @dias_aluguel, @valor_total, @pagamento)";

            MySqlCommand comm = new MySqlCommand(qry);

            comm.Parameters.Add("@codigo_aluguel", MySqlDbType.Int32);
            comm.Parameters.Add("@cpf_cli", MySqlDbType.String);
            comm.Parameters.Add("@cpf_func", MySqlDbType.String);
            comm.Parameters.Add("@cod_jogo", MySqlDbType.Int32);
            comm.Parameters.Add("@dias_aluguel", MySqlDbType.Int32);
            comm.Parameters.Add("@valor_total", MySqlDbType.Float);
            comm.Parameters.Add("@pagamento", MySqlDbType.String);

            comm.Parameters["@codigo_aluguel"].Value = a.CodigoAluguel;
            comm.Parameters["@cpf_cli"].Value = a.CPF_Cliente;
            comm.Parameters["@cpf_func"].Value = a.CPF_Funcionario;
            comm.Parameters["@cod_jogo"].Value = a.CodigoJogo;
            comm.Parameters["@dias_aluguel"].Value = a.Dias;
            comm.Parameters["@valor_total"].Value = a.ValorTotal;
            comm.Parameters["@pagamento"].Value = a.Pagamento;

            dbGames.ExecuteSQL_NonQuery(comm);
        }

        public int max_cod_aluguel()
        {
            int total;

            Banco conexao = Banco.GetInstance();

            string qry = "SELECT MAX(codigo_aluguel) FROM aluguel";

            MySqlCommand comm = new MySqlCommand(qry);

            total = conexao.ExecuteSQL_Scalar_int(comm);
            
            return total;
        }
    }
}
