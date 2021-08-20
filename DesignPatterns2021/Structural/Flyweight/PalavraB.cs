using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Flyweight
{
    class PalavraB : Palavra
    {
        public PalavraB()
        {
            simbolo = 'B';
            altura = 100;
            largura = 140;
            ascendente = 72;
            descendente = 0;
        }

        public override void Exibir(int tamanhoPonto)
        {
            this.tamanhoPonto = tamanhoPonto;
            Console.WriteLine(simbolo + " (tamanhoPonto " + this.tamanhoPonto + ") ");
        }
    }
}
