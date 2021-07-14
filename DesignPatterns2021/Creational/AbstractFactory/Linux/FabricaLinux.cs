using DesignPatterns2021.Creational.AbstractFactory.Linux;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.AbstractFactory
{
    //Concrete Factory
    public class FabricaLinux : IAbstractFactory
    {
        public IBotao CriarBotao()
        {
            return new BotaoLinux();
        }

        public ITela CriarTela()
        {
            return new TelaLinux();
        }
    }
}
