using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LojaGames.Model;
using LojaGames.Model.DAO;

namespace LojaGames.Controller
{
    class ClienteBanco
    {
        ClienteDAO clienteDao = new ClienteDAO();

        public void SalvarCliente(Cliente c) //Método para Salvar um Cliente no BancoPES
        {
            PessoaDAO pessoaDao = new PessoaDAO();
            pessoaDao.Create(c);

            ClienteDAO cliDao = new ClienteDAO();
            cliDao.Create(c);
        }
        
    }
}
