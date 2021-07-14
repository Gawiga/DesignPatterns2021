using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.FactoryMethod
{
    //Concrete Creator
    public class FabricaRodoviaria : FactoryMethod
    {
        //Factory Method
        public override ITransporte ObterTransporte()
        {
            return new Caminhao();
        }
    }
}
