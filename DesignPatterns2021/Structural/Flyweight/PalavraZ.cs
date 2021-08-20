using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Flyweight
{
    class PalavraZ : Palavra
    {
        public PalavraZ()
        {
            simbolo = 'Z';
            altura = 100;
            largura = 100;
            ascendente = 68;
            descendente = 0;
        }

        public override void Exibir(int tamanhoPonto)
        {
            this.tamanhoPonto = tamanhoPonto;
            Console.WriteLine(simbolo + " (tamanhoPonto " + this.tamanhoPonto + ") ");
        }
    }
}
