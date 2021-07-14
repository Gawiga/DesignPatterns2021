using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.FactoryMethod
{
    public abstract class FactoryMethod
    {
        public string ObterEndereco()
        {
            return "Endereço";
        }

        public abstract ITransporte ObterTransporte();

    }
}
