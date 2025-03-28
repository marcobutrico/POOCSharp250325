//Heranca - uma classe que herda de outra atributo e metodo de outra classe
// carro - modelo, marca, quilometragem
// carroeletrico - bateria, tempo de carga
//carro combustao - combustivel


//using heranca;

//Carroeletrico carroE = new Carroeletrico();

//carroE.marca = "Tesla";
//carroE.bateria = 200;

//Carrocombustao carroA = new Carrocombustao();
//carroA.marca = "Fiat";
//carroA.combustivel = "gasolina";

//Carro meucarro;
//Console.WriteLine("Digite E para carro eletrico ou digite C para carro a combustao");
//string opcao = Console.ReadLine();

//if(opcao == "E")
//{
//    meucarro = new Carroeletrico();
//}
//else
//{
//    meucarro = new Carrocombustao();
//}


using heranca;

Pessoafisica pessoa1 = new Pessoafisica();

pessoa1.cpf = "420.106.785-42";

Console.WriteLine("Digite seu cpf:");
string cpf = Console.ReadLine();

if