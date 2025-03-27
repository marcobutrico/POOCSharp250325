using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace POO
{
    class Produto
    {
        public string produto;
        public double preco;
        public int estoque;

        public double CalcularTotal()
        {
            return preco * estoque;

        }
    }
}
