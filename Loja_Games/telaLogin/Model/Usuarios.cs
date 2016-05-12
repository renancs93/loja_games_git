using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaGames.Model
{
    class Usuarios
    {
        //Declaração das Variáveis
        private string nome;
        private string senha;

        public enum tipo
        {
            admin = 1,
            func = 2
        }    

        //Declaração das Propriedades
        public string Nome { get; set; }
        public string Senha { get; set; }
    }
}
