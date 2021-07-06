using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.AbstractFactory
{
    public interface IAbstractFactory
    {
        public ITela CriarTela();
        public IBotao CriarBotao();
    }
}
