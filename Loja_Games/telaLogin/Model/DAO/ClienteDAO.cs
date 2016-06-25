using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Model.DAO
{
    class ClienteDAO
    {
        public void Create(Cliente c)  //Método para criar um cliente
        {
            Banco dbGames = Banco.GetInstance();

            string qry = "INSERT INTO cliente(cpf_cliente) VALUES (@CPF)";

            MySqlCommand comm = new MySqlCommand(qry);

            //relaciona os parâmetros do SQL e o tipo de dado
            comm.Parameters.Add("@CPF", MySqlDbType.Int64);

            //seta nos parametros os dados do objeto passado
            comm.Parameters["@CPF"].Value = c.CPF;

            dbGames.ExecuteSQL_NonQuery(comm);
        }

        public Cliente Read(long cpf)
        {
            Cliente c = new Cliente();
            MySqlConnection conexao = Banco.GetInstance().GetConnection();

            string qry = "SELECT * from cliente WHERE cpf_cliente = " + cpf + "";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                c.CPF = dr.GetInt64("cpf_cliente");
            }

            conexao.Close();
            return c;
        }

        public DataTable ListAllClientes()
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtCliente = new DataTable();

            string qry = "SELECT c.cpf_cliente as CPF_Cliente, p.nome as Nome, p.rua as Rua, p.numero as Número FROM pessoa p, cliente c where c.cpf_cliente = p.cpf_pessoa";

            if (conexao.State != ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtCliente);

            conexao.Close();
            return dtCliente;
        }
    }
}
