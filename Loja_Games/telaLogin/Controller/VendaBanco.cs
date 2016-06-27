using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaGames.Classes;
using LojaGames.Model;
using LojaGames.Model.DAO;

namespace LojaGames.Controller
{
    class VendaBanco
    {
        JogosDAO jogosDao = new JogosDAO();
        VendaDAO vendaDao = new VendaDAO();

        public List<Jogos> AddItem_ListaVenda(int cod)
        {
            return jogosDao.ProcuraCodigo(cod);
        }

        
        public int codigoAtual_venda()
        {
            return vendaDao.max_cod_venda();
        }
       

        public void preencheTiposPagamento(System.Windows.Forms.ComboBox cbxPG)
        {
            cbxPG.DataSource = vendaDao.tiposPagamento();
            cbxPG.DisplayMember = "tipo";
        }

        public void registraVenda(Venda v)
        {
            vendaDao.Create(v);
        }

        /*public int  SelecionaPagamento(string nome)
        {
            return vendaDao.TipoPagamento(nome);
        }*/
    }
}
