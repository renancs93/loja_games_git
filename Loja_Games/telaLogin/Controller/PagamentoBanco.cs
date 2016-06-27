using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaGames.Model.DAO;

namespace LojaGames.Controller
{
    class PagamentoBanco
    {
        PagamentoDAO pagamentoDao = new PagamentoDAO();

        public int buscaCodPagamento(string tipo)
        {
            return pagamentoDao.retorna_codPag_fornecendoTipo(tipo);
        }

    }
}
