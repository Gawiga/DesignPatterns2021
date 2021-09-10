using DesignPatterns2021.Structural.Flyweight;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class StructuralFlyweight
    {
        public static void Execute()
        {
            // construir um documento com texto
            string documento = "AAZZBBZB";
            char[] chars = documento.ToCharArray();

            FabricaPalavras fabrica = new FabricaPalavras();

            // estado extrinsíco
            int tamanhoPonto = 10;

            // para cada palavra use um objeto flyweight
            foreach (char c in chars)
            {
                tamanhoPonto++;
                Palavra palavra = fabrica.ObterPalavras(c);
                palavra.Exibir(tamanhoPonto);
            }

            Console.ReadKey();

        }
    }
}
