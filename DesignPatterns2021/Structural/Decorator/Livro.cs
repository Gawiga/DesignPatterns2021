using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Decorator
{
    /// <summary>
    /// Componente Concreto
    /// Define um objeto ao qual responsabilidade adicionais podem ser anexadas
    /// </summary>
    public class Livro : ItemBiblioteca
    {
        protected ItemBiblioteca itemBiblioteca;

        public Livro(string nome, int copias)
        {
            Nome = nome;
            NumeroCopias = copias;
        }

        public int NumeroCopias { get ; set; }
        public string Nome { get; set; }

        public void Exibir()
        {
            Console.WriteLine("Livro: " + Nome + " | Copias: " + NumeroCopias);
        }
    }
}
