using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Visitor
{
    /// <summary>
    /// ConcreteVisitor
    /// </summary>
    public class ImpostoSP : Visitor
    {
        public override void CalculaTaxaAlcool(Alcool alcool)
        {
            alcool.Preco += alcool.Preco * 0.05;
            Console.WriteLine("A taxa para Alcool em São Paulo é de {0}", alcool.Preco);
        }

        public override void CalculaTaxaComida(Comida comida)
        {
            comida.Preco += comida.Preco * 0.10;
            Console.WriteLine("A taxa para Alcool em São Paulo é de {0}", comida.Preco);
        }

        public override void CalculaTaxaEletronico(Eletronico eletronico)
        {
            eletronico.Preco += eletronico.Preco * 0.20;
            Console.WriteLine("A taxa para Alcool em São Paulo é de {0}", eletronico.Preco);
        }
    }
}
