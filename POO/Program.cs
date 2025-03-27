// Listas
//string[] nomes = new string[5];
//Generico
//versoes antigas do C#
//List<string> listaDeNomes2 = new List<string>();

////jeito novo de escrever
//List<string> listaDeNomes = new();

//listaDeNomes.Add("Marco");
//listaDeNomes.Add("Fulano");
//listaDeNomes.Add("Sicrano");
//listaDeNomes.Add("Beltrano");

//foreach (var item in listaDeNomes)
//{
//        Console.WriteLine(item);
//}

//listaDeNomes.Remove("Sicrano")

//POO - Programacao Orientada a Objetos
// Inicio em programacao estruturada 
// POO tem como objetivo aproximar a programacao do mundo real
// Separr nossos sistemas em partes menores

//Divido em classes e objetos

// Classe - definicao: item da vida real representado em codigo
// Toda classe tem atributos (caracteristicas) e metodos (acoes)

//Objeto - Instancia de uma classe
using POO;

//Carro carro1 = new Carro();
//carro1.modelo = "HB20";
//carro1.marca = "Hyundai";
//carro1.anoFabricacao = 2024;

//carro1.Andar();
//carro1.Parar();

//Carro carro2 = new Carro();
//carro2.modelo = "Fusca";
//carro2.marca = "VW";
//carro2.anoFabricacao = 1969;

//carro2.Andar();
//carro2.Parar();

//Carro carro3 = new Carro();

//carro3.modelo = "Silver Shadow";
//carro3.marca = "Rolls Royce";
//carro3.anoFabricacao = 2023;

//carro3.Andar();
//carro3.Parar();

//List<Carro> carros = new List<Carro>();
//carros.Add(carro1);
//carros.Add(carro2);
//carros.Add(carro3);

//*** Criando Objetos e Classes (25/03)
using POO;

//Livro livro1 = new Livro();
//livro1.titulo = "As trancas do rei careca";
//livro1.paginas = 242;
//livro1.autor = "Joao Traumatizado";

//4 pilares do POO
// classe e objeto
// classe- definicao (molde)
//objeto - instancia da classe

//ferramentas - formas de trabalhar com POO

//encapsulamento e heranca

//abstracao e polimorfismo - amanha

// encapsulamento - esconder encapsulamento e atributo
//evitar que seja acessado diretamente
//conta bancaria (saldo)
//sacar() depositar() podem acessar saldo

//conta.saldo = 300000
//vantagens
//1 - esconder atributo/metodo/classe
//2 - defino regras para alteracao ou listagem


//public - esse atributo/calsse/metodo pode see acessado por qualquer um
//private - esse atributo/calsse/metodo so pode ser accessado dentro dele mesmo
//protected/internal - esse atributo/calsse/metodo so pode ser acessado por ele mesmo ou pela classe pai


Aluno aluno1 = new Aluno();

aluno1.Nome = "Gustavo alencar";
aluno1.Idade = 18;
aluno1.Notafinal = 7.5;

Aluno aluno2 = new Aluno();
aluno2.Nome = "Alexandre Varzea";
aluno2.Idade = 19;
aluno2.Notafinal = 6;

Console.WriteLine($"Aluno: {aluno2.Nome} Idade: {aluno2.Idade} Notafinal: {aluno2.Notafinal}");

Produto produto1 = new Produto();
produto1.produto = "Camiseta";
produto1.preco = 25.99;
produto1.estoque = 5;



Console.WriteLine(produto1.produto);
Console.WriteLine(produto1.preco);
Console.WriteLine(produto1.estoque);



