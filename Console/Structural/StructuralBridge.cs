using DesignPatterns2021.Structural.Bridge;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class StructuralBridge
    {
        public static void Execute()
        {
            string opcao = "";
            string opcao2 = "";
            while (opcao != "3" || opcao2 != "3")
            {
    
                Console.WriteLine("Qual aparelho você deseja utilizar?\n1 - Televisão\n2 - Rádio\n3 - Sair");
                opcao2 = Console.ReadLine();

                IAparelho aparelho = null;

                if (opcao2 == "1")
                    aparelho = new Televisao();
    
                if (opcao2 == "2")
                    aparelho = new Radio();

                Console.WriteLine("Qual controle você deseja utilizar?\n1 - Básico\n2 - Avançado\n3 - Sair");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    var controle = new ControleRemoto(aparelho);
                    controle.BotaoLigar();
                    controle.BotaoAumentarCanal();
                    controle.BotaoAumentarVolume();
                    controle.BotaoAumentarVolume();
                    controle.BotaoAumentarVolume();
                    controle.BotaoAumentarVolume();
                    controle.BotaoAumentarVolume();
                    controle.BotaoLigar();
                }

                if (opcao == "2")
                {
                    var controle = new ControleRemotoAvancado(aparelho);
                    controle.BotaoLigar();
                    controle.BotaoAumentarCanal();
                    controle.BotaoAumentarVolume();
                    controle.BotaoAumentarVolume();
                    controle.Mute();
                    controle.BotaoAumentarVolume();
                    controle.BotaoAumentarVolume();
                    controle.BotaoAumentarVolume();
                    controle.BotaoLigar();
                }
            }
        }

    }
}
