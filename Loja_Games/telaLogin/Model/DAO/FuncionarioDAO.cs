using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaGames.Classes;

namespace LojaGames.Model.DAO
{
    class FuncionarioDAO
    {
        public void Create(Funcionario f)
        {
            Banco dbGames = Banco.GetInstance();
            
            string qry = string.Format("INSERT INTO pessoa (cpf_pessoa, codigo_pessoa,nome) VALUES('{0}','{1}','{2}')", f.CPF, f.Codigo_Funcionario, f.Nome);
            dbGames.ExecuteSQL(qry);

            string qry2 = string.Format("INSERT INTO funcionario (cpf_funcionario, codigo_funcionario, cargo, salario_base) VALUES('{0}','{1}','{2}',{3})", f.CPF, f.Codigo_Funcionario, f.Cargo, f.Salario_Base.ToString().Replace(',','.') /*, f.Data_Inicio.ToString("yyyy-MM-dd")*/);
            dbGames.ExecuteSQL(qry2);

        }

    }
}
