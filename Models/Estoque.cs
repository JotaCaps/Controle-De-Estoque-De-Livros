using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_De_Estoque_De_Livros.Models
{
       public class Regata
    {
        public string Franquia { get; set; }
        public string Tamanho { get; set; }
        public string Quantidade { get; set; }
        public string Jogador { get; set; }
        public string Numero { get; set; }
        public string Valor { get; set; }

    public Regata(string franquia, string tamanho, int quantidade, string jogador, int numero, int valor)
    {
        Franquia = franquia;
        Tamanho = tamanho;
        Quantidade = quantidade;
        Jogador = jogador;
        Numero = numero;
        Valor = valor;
    }

 
    }

    
}