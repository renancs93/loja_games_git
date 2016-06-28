using LojaGames.Model;
using LojaGames.Model.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LojaGames.Controller
{
    class AluguelBanco
    {
        AluguelDAO aluguelDao = new AluguelDAO();

        public void RegistraAluguel(Aluguel a)
        {
            aluguelDao.Create(a);
        }

        public int codigoAtual_Aluguel()
        {
            return aluguelDao.max_cod_aluguel();
        }

        public DataTable todosAlugueis()
        {
            return aluguelDao.exibiTodosAlugueis();
        }

        public DataTable todosAlugueis_cod(int cod)
        {
            return aluguelDao.exibiTodosAlugueis_cod(cod);
        }

        public DataTable todosAlugueis_cli(long cpf)
        {
            return aluguelDao.exibiTodosAlugueis_cli(cpf);
        }

    }
}
