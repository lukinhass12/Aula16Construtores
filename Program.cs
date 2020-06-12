using System;

namespace Aula16Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo game1 = new Jogo("Watch Dogs", 40, "Jogo de mundo aberto", "Disponível na Epic Games.");
            System.Console.WriteLine(game1.nome);
            System.Console.WriteLine(game1.preco);
            System.Console.WriteLine(game1.descricao);
            System.Console.WriteLine(game1.estoque);

            Jogo game2 = new Jogo("Counter Strinke: Global Offesive", 35, "Jogo de tiro", "Disponível na Steam.");
            System.Console.WriteLine(game2.nome);
            System.Console.WriteLine(game2.preco);
            System.Console.WriteLine(game2.descricao);
            System.Console.WriteLine(game2.estoque); 
            
            Jogo game3 = new Jogo("Dota 2", 000,"MOBA", "Disponível na Steam.");
            System.Console.WriteLine(game3.nome);
            System.Console.WriteLine(game3.preco);
            System.Console.WriteLine(game3.descricao);
            System.Console.WriteLine(game3.estoque);
        }
    }
}
