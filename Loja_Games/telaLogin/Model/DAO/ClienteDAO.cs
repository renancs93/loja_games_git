using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
}
