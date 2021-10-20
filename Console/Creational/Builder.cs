using DesignPatterns2021.Creational.Builder;
using System;

namespace DesignPatternsExecutavel
{
    class Builder
    {
        public static void Execute()
        {
            string valor = "";

            while (valor != "4")
            {
                Console.WriteLine("Qual casa você deseja construir?\n" +
                    "1 - Alvenaria | 2 - Madeira | 3 - Papel | 4 - Sair");

                valor = Console.ReadLine();

                if (valor.ToString() == "1")
                {
                    var builder = new ConstruirCasaAlvenaria();
                    ConstruirCasa(builder);
                    var casa = builder.ObterCasaAlvenaria();
                    ExibirResposta(casa);
                }

                if (valor.ToString() == "2")
                {
                    var builder = new ConstruirCasaMadeira();
                    ConstruirCasa(builder);
                    var casa = builder.ObterCasaMadeira();
                    ExibirResposta(casa);
                }

                if (valor.ToString() == "3")
                {
                    var builder = new ConstruirCasaPapel();
                    ConstruirCasa(builder);
                    var casa = builder.ObterCasaPapel();
                    ExibirResposta(casa);
                }
            }
        }

        private static void ConstruirCasa(IBuilder builder)
        {
            var diretor = new Director
            {
                Builder = builder
            };

            diretor.ConstruirCasa();
        }

        private static void ExibirResposta(object casa)
        {
            Console.WriteLine("Sua " + casa.GetType().Name + " está pronta");
        }
    }
}