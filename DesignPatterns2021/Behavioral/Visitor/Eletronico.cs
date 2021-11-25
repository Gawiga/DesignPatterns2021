using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Visitor
{
    public class Eletronico : Produto
    {
        public Eletronico(string nome, int preco) : base(nome, preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override void CalcularTaxas(Visitor visitor)
        {
            visitor.CalculaTaxaEletronico(this);
        }
    }
}
