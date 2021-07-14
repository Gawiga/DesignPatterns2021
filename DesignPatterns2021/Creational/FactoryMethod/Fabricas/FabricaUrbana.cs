using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.FactoryMethod
{
    public class FabricaUrbana : FactoryMethod
    {
        public override ITransporte ObterTransporte()
        {
            return new Bicicleta();
        }
    }
}
