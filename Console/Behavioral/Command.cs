using DesignPatterns2021.Behavioral.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Command : IPadrao
    {
        public void Execute()
        {
            var usuario = new Usuario();
            string direcao = "";
            while (direcao != "9")
            {
                Console.WriteLine("Você está na posição ({0}, {1}), informe para onde deseja ir\n" +
                    "1 - Cima (Y+1)\n" +
                    "2 - Esquerda (X-1)\n" +
                    "3 - Direita (X+1)\n" +
                    "4 - Baixo (Y-1)\n" +
                    "7 - Reexecutar os ultimos 2 comandos APÓS terem sidos desfeitos\n" +
                    "8 - Desfazer 3\n" +
                    "9 - SAIR\n", 
                    usuario.X, usuario.Y);
                direcao = Console.ReadLine();

                if (direcao == "7")
                {
                    usuario.Retornar(2);

                } else if (direcao == "8")
                {
                    usuario.Desfazer(3);

                } else
                {
                    var comando = ObterDirecao(direcao);
                    usuario.Adicionar(comando);
                }
            }

        }

        private static char ObterDirecao(string direcao)
        {
            switch (direcao)
            {
                case "1":
                    return 'C';
                case "2":
                    return 'E';
                case "3":
                    return 'D';
                case "4":
                    return 'B';
                default:
                    break;
            }
            return ' ';
            
        }
    }
}
