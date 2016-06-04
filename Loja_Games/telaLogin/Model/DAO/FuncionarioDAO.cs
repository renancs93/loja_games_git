using LojaGames.Classes;
using MySql.Data.MySqlClient;

namespace LojaGames.Model.DAO
{
    class FuncionarioDAO
    {
        public void Create(Funcionario f)
        {
            Banco dbGames = Banco.GetInstance();
            //MySqlConnection conexao = Banco.GetInstance().GetConnection();

            string qry = "INSERT INTO funcionario(cpf_funcionario, codigo_funcionario, cargo, salario_base, data_inicio)"
                        + "VALUES (@CPF, @cod, @cargo , @salarioBase, @dataInicio)";

            MySqlCommand comm = new MySqlCommand(qry);

            //relaciona os parametros do SQL e o tipo do dado
            comm.Parameters.Add("@CPF", MySqlDbType.Int64);
            comm.Parameters.Add("@cod", MySqlDbType.Int64);
            comm.Parameters.Add("@cargo", MySqlDbType.String);
            comm.Parameters.Add("@salarioBase", MySqlDbType.Float);
            comm.Parameters.Add("@dataInicio", MySqlDbType.DateTime);

            //seta nos paramentros os dados do objeto passado
            comm.Parameters["@CPF"].Value = f.CPF;
            comm.Parameters["@cod"].Value = f.Codigo_Funcionario;
            comm.Parameters["@cargo"].Value = f.Cargo;
            comm.Parameters["@salarioBase"].Value = f.Salario_Base;
            comm.Parameters["@dataInicio"].Value = f.Data_Inicio;

            //chamada para execução do SQL na tabela Pessoa
            dbGames.ExecuteSQL_NonQuery(comm);

            
            

        }

    }
}
