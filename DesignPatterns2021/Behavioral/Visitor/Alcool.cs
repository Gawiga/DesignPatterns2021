using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Visitor
{
    /// <summary>
    /// ConcretElement
    /// </summary>
    public class Alcool : Produto
    {
        public Alcool(string nome, int preco) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override void CalcularTaxas(Visitor visitor)
        {
            visitor.CalculaTaxaAlcool(this);
        }
    }
}
