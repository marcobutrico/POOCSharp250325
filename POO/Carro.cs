using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Classe - definicao: item da vida real representado em codigo
// Toda classe tem atributos (caracteristicas) e metodos (acoes)

namespace POO
{
    class Carro
    {
        //Atributos
        public string marca;

        // nomenclatura
        //tudo que e privado tem que ter um sublinhado _
        public string _modelo;
        public int anoFabricacao;

        //Metodos
        // get e set
        public void SetModelo(string mod)
        {
            if (mod == "fiesta" || mod == "HB20")
            {
                _modelo = mod;

            }
            else
            {
                Console.WriteLine("Carro invalido");
            }
      

        }
        public void Andar()
        {
            Console.WriteLine("O carro esta andando!");
        }
        public void Parar()
        {
            Console.WriteLine("O carro esta parado!");
        }
        public void MostrarInformacoes()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {_modelo}, Ano de Fabricacao {anoFabricacao}");

        }
        public string Getmodelo()
        {
            return _modelo;
        }
    }
}
