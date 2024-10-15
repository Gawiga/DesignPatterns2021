using DesignPatterns2021.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Decorator : IPadraoExecutavel
    {
        public void Execute()
        {
            var livro = new Livro("O pequeno principe", 10);
            livro.Exibir();

            var revista = new Revista("Almanaque Abril", 5);
            revista.Exibir();

            Console.WriteLine("Transformando o livro e a revista em objetos emprestáveis");

            var livroEmprestavel = new Emprestavel(livro);
            var revistaEmprestavel = new Emprestavel(revista);

            livroEmprestavel.ObterItemEmprestado("João da Cunha");
            livroEmprestavel.Exibir();

            revistaEmprestavel.ObterItemEmprestado("Joaquim Nabuco");
            revistaEmprestavel.Exibir();

            Console.ReadKey();

        }
    }
}
