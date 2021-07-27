using DesignPatterns2021.Creational.Prototype;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    public class CreationalPrototype
    {
        public static void Execute()
        {
            string opcao;
            do
            {
                Console.WriteLine("Digite o objeto que deseja criar: \n1 - Circulo\n2 - Retangulo\n3 - Sair");
                opcao = Console.ReadLine();

                if (opcao.ToString() == "1")
                {
                    Console.WriteLine("Digite o raio do ciculo");
                    var raio = Convert.ToInt32(Console.ReadLine());

                    var circulo = new Circulo(raio);
                    var circuloClone = circulo.Clone();

                    Console.WriteLine("Área Original: " + (Math.PI * (circulo.Raio * 2)));

                    Console.WriteLine("Área Clone: " + (Math.PI * (circuloClone.Raio * 2)));
                }

                if (opcao.ToString() == "2")
                {
                    Console.WriteLine("Digite a largura");
                    var largura = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Digite a altura");
                    var altura = Convert.ToInt32(Console.ReadLine());

                    var retangulo = new Retangulo
                    {
                        Altura = altura,
                        Largura = largura,
                    };

                    var retanguloClone = retangulo.Clone();

                    Console.WriteLine("Área Original: " + (retangulo.Altura * retangulo.Largura));
                    Console.WriteLine("Área Clone: " + (retanguloClone.Altura * retangulo.Largura));

                }
            } while (opcao != "3");
        }
    }
}
