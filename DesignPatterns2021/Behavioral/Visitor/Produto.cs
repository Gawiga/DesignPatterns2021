using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Visitor
{
    /// <summary>
    /// Element
    /// </summary>
    public abstract class Produto
    {
        public Produto(string nome, int preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome { get; set; }
        public double Preco { get; set; }

        public abstract void CalcularTaxas(Visitor visitor);
    }
}
