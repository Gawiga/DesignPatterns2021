using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Visitor
{
    public abstract class Visitor
    {
        public abstract void CalculaTaxaComida(Comida comida);
        public abstract void CalculaTaxaAlcool(Alcool alcool);
        public abstract void CalculaTaxaEletronico(Eletronico eletronico);
    }
}
