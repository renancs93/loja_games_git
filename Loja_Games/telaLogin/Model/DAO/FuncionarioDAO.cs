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

            string qry = "UPDATE funcionario SET codigo_funcionario = @cod, cargo = @cargo, salario_base = @salario_base, data_inicio = @data_inicio WHERE cpf_funcionario = "+cpf_func+"";  

            MySqlCommand comm = new MySqlCommand(qry);

            //relaciona os parametros do SQL e o tipo do dado
            comm.Parameters.Add("@cod", MySqlDbType.Int32);
            comm.Parameters.Add("@cargo", MySqlDbType.String);
            comm.Parameters.Add("@salario_base", MySqlDbType.Float);
            comm.Parameters.Add("@data_inicio", MySqlDbType.DateTime);

            //seta nos paramentros os dados do objeto passado
            comm.Parameters["@cod"].Value = f.Codigo_Funcionario;
            comm.Parameters["@cargo"].Value = f.Cargo;
            comm.Parameters["@salario_base"].Value = f.Salario_Base;
            comm.Parameters["@data_inicio"].Value = f.Data_Inicio;

            //add username e senha

            dbGames.ExecuteSQL_NonQuery(comm);
        }

        public DataTable ListAllFuncionarios()
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtFuncionario = new DataTable();

            string qry = "SELECT f.cpf_funcionario as CPF, p.nome as Nome, f.codigo_funcionario as Codigo, f.cargo as Cargo, f.salario_base as Salário, f.data_inicio as Data_Admissão"
                       + " FROM funcionario f, pessoa p WHERE p.cpf_pessoa = f.cpf_funcionario";

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
                funcionario.Data_Inicio = dr.GetDateTime("data_inicio");
                funcionario.Codigo_Funcionario = dr.GetInt32("codigo_funcionario");

            }

            conexao.Close();
            return funcionario;
        }

        public DataTable BuscaFunc_cpf(string cpf_func)
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtFuncionario = new DataTable();

            string qry = "SELECT f.cpf_funcionario as CPF, p.nome as Nome, p.rg as RG, p.data_nascimento as Data_Nascimento, p.telefone as Telefone, p.sexo as Sexo, p.estado_civil as Estado_Civil, p.email as Email, p.rua as Rua, p.numero as Numero, p.bairro as Bairro, p.estado as Estado, p.cep as CEP, p.cidade as Cidade"
                       + " FROM funcionario f, pessoa p where f.cpf_funcionario = p.cpf_pessoa and f.cpf_funcionario = " + cpf_func + "";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtFuncionario);

            conexao.Close();
            return dtFuncionario;
        }

        public DataTable BuscaFunc_nome(string nome)
        {
            MySqlConnection conexao = Banco.GetInstance().GetConnection();
            DataTable dtFuncionario = new DataTable();

            string qry = "SELECT f.cpf_funcionario as CPF, p.nome as Nome, p.rg as RG, p.data_nascimento as Data_Nascimento, p.telefone as Telefone, p.sexo as Sexo, p.estado_civil as Estado_Civil, p.email as Email, p.rua as Rua, p.numero as Numero, p.bairro as Bairro, p.estado as Estado, p.cep as CEP, p.cidade as Cidade"
                       + " FROM funcionario f, pessoa p WHERE p.cpf_pessoa = f.cpf_funcionario and p.nome like '%"+nome+"%'";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlDataAdapter objAdapter = new MySqlDataAdapter(qry, conexao);
            objAdapter.Fill(dtFuncionario);

            conexao.Close();
            return dtFuncionario;
        }

        public string BuscarFunc_cod(int codigo)
        {
            string nome;

            //MySqlConnection conexao = Banco.GetInstance().GetConnection();
            Banco conexao = Banco.GetInstance();

            string qry = "SELECT p.nome FROM pessoa p, funcionario f WHERE  f.codigo_funcionario = "+codigo;

            MySqlCommand comm = new MySqlCommand(qry);

            nome = conexao.ExecuteSQL_Scalar_string(comm);

            if (nome == null || nome == string.Empty)
            {
                nome = "Funcionário não encontrado";
            }

            return nome;
        }


        public int prox_cod_funcionario()
        {
            int total;

            //MySqlConnection conexao = Banco.GetInstance().GetConnection();
            Banco conexao = Banco.GetInstance();

            string qry = "SELECT MAX(codigo_funcionario) from funcionario";

            MySqlCommand comm = new MySqlCommand(qry);

            total = conexao.ExecuteSQL_Scalar_int(comm);

            if(total == null || total == System.Convert.ToInt32(string.Empty))
            {
                total = 0;
            }

            return total;
        }

    }
}
