using DesignPatterns2021.Creational.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class AbstractFactory : IPadrao
    {
        public void Execute()
        {
            string valor = "";
            while (valor != "3") 
            {
                Console.WriteLine("Digite o SO desejado: 1 - Windows | 2 - Linux | 3 - Sair");
                valor = Console.ReadLine();

                IAbstractFactory _fabrica;
                if (valor.ToString() == "1")
                {
                    _fabrica = new FabricaWindows();
                    DesenharTela(_fabrica);
                }

                if (valor.ToString() == "2")
                {
                    _fabrica = new FabricaLinux();
                    DesenharTela(_fabrica);
                }
            }
        }

        private static void DesenharTela(IAbstractFactory _fabrica)
        {
            var botao = _fabrica.CriarBotao();
            Console.WriteLine(botao.Valor);
            var tela = _fabrica.CriarTela();
            Console.WriteLine(tela.Valor);

        }
    }
}
