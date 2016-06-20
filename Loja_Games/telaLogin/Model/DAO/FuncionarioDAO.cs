using System.Collections.Generic;
using System.Data;
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

        public void Delete(long cpf_func)
        {
            Banco dbGames = Banco.GetInstance();

            string qry = "Delete from funcionario where cpf_funcionario = "+cpf_func+"";

            MySqlCommand comm = new MySqlCommand(qry);

            //comm.Parameters["@cpf_func"].Value = cpf_func;

            dbGames.ExecuteSQL_NonQuery(comm);
        }
        
        public void Update(long cpf_func, Funcionario f)
        {
            Banco dbGames = Banco.GetInstance();


            string qry = "UPDATE INTO funcionario(cpf_funcionario, codigo_funcionario, cargo, salario_base, data_inicio)"
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

            dbGames.ExecuteSQL_NonQuery(comm);
        }

        public DataTable ListAllFuncionarios()
        {
            /*
            List<Funcionario> listFunc = new List<Funcionario>();
            Funcionario f;
            */

            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtFuncionario = new DataTable();

            string qry = "SELECT f.cpf_funcionario, p.nome, f.cargo, f.codigo_funcionario, f.salario_base from funcionario f, pessoa p where p.cpf_pessoa = f.cpf_funcionario";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtFuncionario);

            conexao.Close();
            return dtFuncionario;
            
        }

        public Funcionario Read(long cpf)
        {
            Funcionario funcionario = new Funcionario();
            MySqlConnection conexao = Banco.GetInstance().GetConnection();

            string qry = "SELECT * FROM funcionario where cpf_funcionario = "+cpf+"";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if(dr.Read())
            {
                //funcionario = new Funcionario();

                funcionario.CPF = dr.GetInt64("cpf_funcionario");
                funcionario.Cargo = dr.GetString("cargo");
                funcionario.Salario_Base = dr.GetFloat("salario_base");

            }

            conexao.Clone();
            return funcionario;
        }

        public DataTable ListFuncionario(long cpf_func)
        {

            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtFuncionario = new DataTable();
            Funcionario f = new Funcionario();

            string qry = "SELECT * from funcionario where cpf_funcionario = " + cpf_func + "";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtFuncionario);
            
            conexao.Close();
            return dtFuncionario;

        }

    }
}
