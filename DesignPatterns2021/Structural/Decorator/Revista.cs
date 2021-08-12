using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Decorator
{
    public class Revista : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca;

        public Revista(string nome, int copias)
        {
            Nome = nome;
            NumeroCopias = copias;
        }

        public int NumeroCopias { get; set; }
        public string Nome { get; set; }

        public void Exibir()
        {
            Console.WriteLine("Revista: " + Nome + " | Copias: " + NumeroCopias);
        }
    }
}
