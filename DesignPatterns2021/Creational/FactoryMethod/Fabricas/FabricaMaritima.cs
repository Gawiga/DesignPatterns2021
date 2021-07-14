using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.FactoryMethod
{
    public class FabricaMaritima : FactoryMethod
    {
        public override ITransporte ObterTransporte()
        {
            return new Navio();
        }
    }
}
