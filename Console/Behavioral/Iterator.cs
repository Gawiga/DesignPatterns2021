using DesignPatterns2021.Behavioral.Iterator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Iterator
    {
        public static void Execute()
        {
            var opcao = "";
            var palavras = new PalavrasCollection();

            while (opcao != "9")
            {
                Console.WriteLine("Digite 1 para exibir a coleção\n" +
                    "Digite 2 para reverter a ordem da coleção\n" +
                    "Digite 9 para sair\n" +
                    "Ou digite apenas a palavra que deseja:");
                opcao = Console.ReadLine();
                
                if (opcao == "1")
                {
                    foreach (var palavra in palavras)
                    {
                        Console.WriteLine(palavra);
                    }    
                } 
                else if (opcao == "2") 
                {
                    palavras.DirecaoReversa();
                    foreach (var palavra in palavras)
                    {
                        Console.WriteLine(palavra);
                    }
                } 
                else
                {
                    palavras.AddItem(opcao);
                }
            }
        }
    }
}
