using LojaGames.Classes;
using MySql.Data.MySqlClient;

namespace LojaGames.Model.DAO
{
    class PessoaDAO
    {

        public void Create(Pessoa p)
        {
            Banco dbGames = Banco.GetInstance();
            //MySqlConnection conexao = Banco.GetInstance().GetConnection();

            string qry = "INSERT INTO pessoa (cpf_pessoa, nome, rg, data_nascimento, telefone, sexo ,estado_civil, email, rua, numero, bairro, estado, cep, cidade)"
                        + "VALUES (@CPF, @nome, @rg, @dtNasc, @telefone, @sexo, @EstadoCivil, @email, @rua, @numero, @bairro, @estado, @cep, @cidade)";

            MySqlCommand comm = new MySqlCommand(qry);

            //relaciona os parametros do SQL e o tipo do dado
            comm.Parameters.Add("@CPF", MySqlDbType.Int64);
            comm.Parameters.Add("@nome", MySqlDbType.String);
            comm.Parameters.Add("@rg", MySqlDbType.String);
            comm.Parameters.Add("@dtNasc", MySqlDbType.DateTime);
            comm.Parameters.Add("@telefone", MySqlDbType.String);
            comm.Parameters.Add("@sexo", MySqlDbType.VarChar);
            comm.Parameters.Add("@EstadoCivil", MySqlDbType.String);
            comm.Parameters.Add("@email", MySqlDbType.String);
            comm.Parameters.Add("@rua", MySqlDbType.String);
            comm.Parameters.Add("@numero", MySqlDbType.Int32);
            comm.Parameters.Add("@bairro", MySqlDbType.String);
            comm.Parameters.Add("@estado", MySqlDbType.String);
            comm.Parameters.Add("@cep", MySqlDbType.String);
            comm.Parameters.Add("@cidade", MySqlDbType.String);

            //seta nos paramentros os dados do objeto passado
            comm.Parameters["@CPF"].Value = p.CPF;
            comm.Parameters["@nome"].Value = p.Nome;
            comm.Parameters["@rg"].Value = p.RG;
            comm.Parameters["@dtNasc"].Value = p.DataNascimento;
            comm.Parameters["@telefone"].Value = p.Telefone;
            comm.Parameters["@sexo"].Value = p.Sexo;
            comm.Parameters["@EstadoCivil"].Value = p.EstadoCivil;
            comm.Parameters["@email"].Value = p.Email;
            comm.Parameters["@rua"].Value = p.Rua;
            comm.Parameters["@numero"].Value = p.Numero;
            comm.Parameters["@bairro"].Value = p.Bairro;
            comm.Parameters["@estado"].Value = p.Estado;
            comm.Parameters["@cep"].Value = p.Cep;
            comm.Parameters["@cidade"].Value = p.Cidade;

            //chamada para execução do SQL na tabela Pessoa
            dbGames.ExecuteSQL_NonQuery(comm);

        }

        public Pessoa Read(long cpf)
        {
            Pessoa pessoa = new Pessoa();
            MySqlConnection conexao = Banco.GetInstance().GetConnection();

            string qry = "SELECT * FROM pessoa where cpf_pessoa = " + cpf + "";

            if (conexao.State != System.Data.ConnectionState.Open)
                conexao.Open();

            MySqlCommand comm = new MySqlCommand(qry, conexao);
            MySqlDataReader dr = comm.ExecuteReader();

            if (dr.Read())
            {
                //funcionario = new Funcionario();

                
                pessoa.Nome = dr.GetString("nome");
                pessoa.Rua = dr.GetString("rua");
                
            }

            conexao.Clone();
            return pessoa;
        }

    }
}
