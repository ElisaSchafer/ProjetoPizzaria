using ProjetoPizzaria.Models;

Console.WriteLine("Bem-vindo ao Projeto da Pizzaria");
Console.WriteLine("ESCOLHA UMA OPÇÃO:");
Console.WriteLine("1 - Adicionar Pizza");
Console.WriteLine("2 - Listar Pizzas");

Console.WrietLine("Digite sua opção");

switch(Pizzaria) {
    case 1:
    
}

Console.WriteLine("Adicionar uma Pizza!");

var pizzaria = new Pizzaria();

Console.WriteLine("Digite o nome da Pizza:");
var nome = Console.ReadLine();
Console.WriteLine("Digite os sabores da Pizza separados por vírgulas:");
var sabores = Console.ReadLine();
Console.WriteLine("Digite o preço da Pizza (formato R$00.00):");
var preco = double.Parse(Console.ReadLine());

pizzaria.Nome = nome;
pizzaria.Sabores = sabores;
pizzaria.Preco = preco;

