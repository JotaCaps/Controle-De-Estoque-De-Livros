using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_De_Estoque_De_Livros.Models
{
    public class Estoque 
    {

    }
    
    public class Regata
    {
        public string Franquia { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public string Jogador { get; set; }
        public string Numero { get; set; }
        public string Valor { get; set; }

        public static List<Regata> listaRegatas = new List<Regata>(); 

        public void AdicionarRegata()
        {

            Regata regata = new Regata();

            Console.WriteLine("Digite a franquia da regata");
            Franquia = Console.ReadLine();

            Console.WriteLine("Digite o tamnho da regata");
            Tamanho = Console.ReadLine();

            Console.WriteLine("Digite a cor da regata");
            Cor = Console.ReadLine();

            Console.WriteLine("Digite de qual jogador é a regata");
            Jogador = Console.ReadLine();

            Console.WriteLine("Digite o numero da regata");
            Numero = Console.ReadLine();

            Console.WriteLine("Digite o valor da regata");
            Valor = Console.ReadLine();

            listaRegatas.Add(regata);

        }

        public void ListarRegatas()
        {
            static void Main(string[] args)
       {
        for (int i = 0; i < 3; i++)
        {
            Regata regata = new Regata();
            regata.AdicionarRegata();
        }

        Console.WriteLine("\nRegatas cadastradas:");
        foreach (var regata in Regata.listaRegatas)
        {
            Console.WriteLine($"Franquia: {regata.Franquia}, Tamanho: {regata.Tamanho}, Cor: {regata.Cor}, Jogador: {regata.Jogador}, Número: {regata.Numero}, Valor: {regata.Valor}");
        }
       }
        }
    }


    
}