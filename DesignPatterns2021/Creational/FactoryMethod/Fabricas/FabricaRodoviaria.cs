using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.FactoryMethod
{
    public class FabricaRodoviaria : FactoryMethod
    {
        public override ITransporte ObterTransporte()
        {
            return new Caminhao();
        }
    }
}
