using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Livro
    {
        //Atributos
        public string titulo;
        public string autor;
        public int paginas;

        public void Ler()
        {
            Console.WriteLine("O livro esta em leitura");
        }
        public void ProximaPagina()
        {
            Console.WriteLine("Avancando a proxima pagina");

        }
        public void MostrarInformacoes()
        {
            Console.WriteLine($"O livro {titulo} do {autor} tem {paginas} ");
        }

     



    }
}

