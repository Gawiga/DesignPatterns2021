using DesignPatterns2021.Behavioral.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class TemplateMethod : IPadrao
    {
        public void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("\nDigite 9 para sair!");
                opcao = Console.ReadLine();

                var pratoA = new PratoA();
                var pratoB = new PratoB();

                Garcom.ServirPrato(pratoA);
                Garcom.ServirPrato(pratoB);
            }
        }
    }
}
