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

        public DataTable buscaJogo_nome(string jogo)
        {
            return jogosDao.buscaPorNomeJogo(jogo);
        }

        public DataTable buscaJogo_console(string console)
        {
            return jogosDao.buscaPorConsoleJogo(console);
        }

        public DataTable buscaJogo_genero(string genero)
        {
            return jogosDao.buscaPorGeneroJogo(genero);
        }

        public DataTable Add_JogoTabelaVenda(int cod)
        {
            return jogosDao.itemVenda(cod);
        }

        public string buscaJogo_cod(int cod)
        {
            return jogosDao.buscaJogoCod(cod);
        }

        public Jogos buscarJogo_cod_edit(int codigo)
        {
            return jogosDao.Read(codigo);
        }

        public void AtualizarJogo(Jogos jogo)
        {
            jogosDao.Update(jogo);
        }

        public void Deletar_jogo(int codigo_jogo)
        {
            jogosDao.Delete(codigo_jogo);
        }

    }
}
