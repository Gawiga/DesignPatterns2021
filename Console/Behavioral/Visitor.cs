using DesignPatterns2021.Behavioral.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Visitor : IPadrao
    {
        public void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("Digite 9 para sair!");
                opcao = Console.ReadLine();

                var cerveja = new Alcool("Cerveja", 10);
                var arroz = new Comida("Arroz", 100);
                var ipad = new Eletronico("iPad", 1000);

                var impostoSP = new ImpostoSP();
                cerveja.CalcularTaxas(impostoSP);
                arroz.CalcularTaxas(impostoSP);
                ipad.CalcularTaxas(impostoSP);

                var alcool = new Alcool("Cerveja", 10);
                var comida = new Comida("Arroz", 100);
                var eletronico = new Eletronico("iPad", 1000);

                var impostoRJ = new ImpostoRJ();
                alcool.CalcularTaxas(impostoRJ);
                comida.CalcularTaxas(impostoRJ);
                eletronico.CalcularTaxas(impostoRJ);
            }
        }
    }
}
