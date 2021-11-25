using DesignPatterns2021.Behavioral.Memento;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Memento : IPadrao
    {
        public void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("Digite 9 para sair!\n");
                opcao = Console.ReadLine();

                var prospectoVenda = new ProspectoVenda();

                prospectoVenda.Nome = "Joaquim da Silva";
                prospectoVenda.Telefone = "(11) 99999-3333";
                prospectoVenda.Orcamento = 250.00;

                var memoria = new Caretaker();
                memoria.Memento = prospectoVenda.SalvarLembranca();

                prospectoVenda.Nome = "Nilza Martins";
                prospectoVenda.Telefone = "(11) 33333-5555";
                prospectoVenda.Orcamento = 1000.00;

                prospectoVenda.RestaurarLembranca(memoria.Memento);
                
            }
        }
    }
}
