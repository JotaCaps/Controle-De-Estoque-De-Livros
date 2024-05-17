using Controle_De_Estoque_De_Livros.Models;

using System;
using System.Collections.Generic;

public class Regata
{
    public string Franquia { get; set; }
    public string Tamanho { get; set; }
    public int Quantidade { get; set; }
    public string Jogador { get; set; }
    public int Numero { get; set; }
    public decimal Valor { get; set; }

    public Regata(string franquia, string tamanho, int quantidade, string jogador, int numero, decimal valor)
    {
        Franquia = franquia;
        Tamanho = tamanho;
        Quantidade = quantidade;
        Jogador = jogador;
        Numero = numero;
        Valor = valor;
    }
}

public class Estoque
{
    private List<Regata> regatas;

    public Estoque()
    {
        regatas = new List<Regata>();
    }

    public void AdicionarRegata(Regata regata)
    {
        regatas.Add(regata);
        Console.WriteLine("Regata adicionada!"); 
    }

    public void ListarRegatas()
    {
        Console.WriteLine("\nLista de Regatas:");
        foreach (var regata in regatas)
        {
            Console.WriteLine($"Franquia: {regata.Franquia}, Tamanho: {regata.Tamanho}, Quantidade: {regata.Quantidade}");
        }
    }

    public void RemoverRegata(string franquia)
    {
        Regata regata = regatas.Find(r => r.Franquia == franquia);
        if (regata != null)
        {
            regatas.Remove(regata);
            Console.WriteLine("Regata removida!");
        }
        else
        {
            Console.WriteLine("Regata não encontrada.");
        }
    }

    public void EntradaEstoque(string franquia, int quantidade)
    {
       Regata regata = regatas.Find(r => r.Franquia == franquia);
       if (regata != null)
       {
            regata.Quantidade += quantidade;
            Console.WriteLine($"Entrada de {quantidade} unidades do produto {franquia} realizada com sucesso.");
       }
       else
       {
            Console.WriteLine("Produto não encontrado.");
       }
    }

    public void SaidaEstoque(string franquia, int quantidade)
    {
        Regata regata = regatas.Find(r => r.Franquia == franquia);
        if (regata != null)
        {
            if (regata.Quantidade >= quantidade)
            {
                regata.Quantidade -= quantidade;
                Console.WriteLine($"Saída de {quantidade} unidades do produto {franquia} realizada com sucesso");
            }
            else
            {
                Console.WriteLine($"Não há estoque suficiente do produto {franquia}");
            } 
        }
        else
        {
            Console.WriteLine("Produto não encontrado");
        }
    }

    public static void Main(string[] args)
    {
        Estoque estoque = new Estoque();
        ExibirMenu(estoque);
    }

    public static void ExibirMenu(Estoque estoque)
    {
        Console.WriteLine("[1] Novo");
        Console.WriteLine("[2] Listar Produtos");
        Console.WriteLine("[3] Remover Produtos");
        Console.WriteLine("[4] Entrada Estoque");
        Console.WriteLine("[5] Saída Estoque");
        Console.WriteLine("[0] Sair");

        switch(Console.ReadLine())
        {
            case "1":
                AdicionarRegata(estoque);
                break;
            case "2":
                estoque.ListarRegatas();
                break;
            case "3":
                RemoverRegata(estoque);
                break;
            case "4":
                EntradaEstoque(estoque);
                break;
            case "5":
                SaidaEstoque(estoque);
                break;
            case "0":
                Console.WriteLine("Encerrando...");
                return;
            default:
                Console.WriteLine("Opção Inválida.");
                break;
        }

        ExibirMenu(estoque);
    }

    public static void AdicionarRegata(Estoque estoque)
    {
        Console.WriteLine("Digite a franquia da regata:");
        string franquia = Console.ReadLine();

        Console.WriteLine("Digite o tamanho regata:");
        string tamanho = Console.ReadLine();

        Console.WriteLine("Digite a quantidade de regatas:");
        int quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite de qual jogador é a regata:");
        string jogador = Console.ReadLine();

        Console.WriteLine("Digite o número da regata:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da regata:");
        decimal valor = decimal.Parse(Console.ReadLine());

        Regata regata = new Regata(franquia, tamanho, quantidade, jogador, numero, valor);
        estoque.AdicionarRegata(regata);
    }
}

