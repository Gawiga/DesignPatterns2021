using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Flyweight
{
    /// <summary>
    /// Concrete Flyweight
    /// </summary>
    class PalavraA : Palavra
    {
        public PalavraA()
        {
            simbolo = 'A';
            altura = 100;
            largura = 120;
            ascendente = 70;
            descendente = 0;
        }

        public override void Exibir(int tamanhoPonto)
        {
            this.tamanhoPonto = tamanhoPonto;
            Console.WriteLine(simbolo + " (tamanhoPonto " + this.tamanhoPonto + ") ");
        }
    }
}
