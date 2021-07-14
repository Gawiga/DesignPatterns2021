using DesignPatterns2021.Creational.AbstractFactory.Windows;

namespace DesignPatterns2021.Creational.AbstractFactory
{
    //Concrete Factory
    public class FabricaWindows : IAbstractFactory
    {
        public IBotao CriarBotao()
        {
            return new BotaoWindows();
        }

        public ITela CriarTela()
        {
            return new TelaWindows();
        }
    }
}
