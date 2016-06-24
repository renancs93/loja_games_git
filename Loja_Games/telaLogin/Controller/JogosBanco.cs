using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaGames.Classes;
using LojaGames.Model.DAO;

namespace LojaGames.Controller
{
    class JogosBanco
    {
        JogosDAO jogosDao = new JogosDAO();

        //Cadastra o novo jogo no banco
        public void CadastraJogo(Jogos j)
        {
            jogosDao.Create(j);
        }

        public DataTable ExibirTodosJogos()
        {
            //metodo para exibir todos jogos do banco
            return jogosDao.ListAll_Jogos();
        }

        public int gerar_codigo_Jogo()
        {
            return jogosDao.max_cod_jogo();
        }

    }
}
