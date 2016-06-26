﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using LojaGames.Model;
using LojaGames.Model.DAO;
using System.Windows.Forms;

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

        public Cliente Buscar_Cliente(long cpf)
        {
            return clienteDao.Read(cpf);
        }

        public string Buscar_Cliente_apenasNome(long cpf)
        {
            return clienteDao.BuscarCli_cpf(cpf);
        }

        public void ExibirTodosClientes(DataGridView dataGrid)
        {
            dataGrid.DataSource = clienteDao.ListAllClientes();
        }
    }
}
