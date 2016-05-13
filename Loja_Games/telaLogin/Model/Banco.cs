using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaGames.Classes;

namespace LojaGames.Model
{
    class Banco
    {
        //lista estática de Funcionarios
        public static Dictionary<long, Funcionario> dicFunc = new Dictionary<long, Funcionario>();

        //lista estática de Clientes
        public static Dictionary<long, Cliente> dicCli = new Dictionary<long, Cliente>();
        
    }
}
