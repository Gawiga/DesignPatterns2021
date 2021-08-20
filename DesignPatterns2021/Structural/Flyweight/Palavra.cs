using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Flyweight
{
    /// <summary>
    /// A class abstrata "Flyweight"
    /// </summary>
    public abstract class Palavra
    {
        protected char simbolo;
        protected int largura;
        protected int altura;
        protected int ascendente;
        protected int descendente;
        protected int tamanhoPonto;

        public abstract void Exibir(int tamanhoPonto);
    }
}
