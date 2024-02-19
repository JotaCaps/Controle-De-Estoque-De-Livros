using Controle_De_Estoque_De_Livros.Models;

Console.WriteLine("Controle de estoque - Loja de Regatas NBA".ToUpper());

Regata r = new Regata
{};

Console.WriteLine("[1] Novo");
Console.WriteLine("[2] Listar Produtos");
Console.WriteLine("[3] Remover Produtos");
Console.WriteLine("[4] Entrada Estoque");
Console.WriteLine("[5] Saída Estoque");
Console.WriteLine("[0] Sair");

switch (Console.ReadLine())
{
    case "1" :
    r.AdicionarRegata();
    break;

    case "2" :
    r.ListarRegatas();
    break;
}

