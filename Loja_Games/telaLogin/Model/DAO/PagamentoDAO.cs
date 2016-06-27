using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LojaGames.Model.DAO
{
    class PagamentoDAO
    {
        public int retorna_codPag_fornecendoTipo(string tipo)
        {
            int cod_pagamento;

            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            //Banco conexao = Banco.GetInstance();

            string qry = "SELECT p.codigo_pagamento FROM pagamento p WHERE p.tipo = '" +tipo+ "'";

            if (conexao.State != ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry);

            cod_pagamento = (int)comm.ExecuteScalar();

            return cod_pagamento;
        }


    }
}
