using DesignPatterns2021.Structural.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class StructuralComposite
    {
        public static void Execute()
        {
            string opcao = "";
            var composite = new Composite();
            while (opcao != "5")
            {
                Console.WriteLine("Qual funcionário você deseja cadastrar?" +
               "\n1 - Desenvolvedor C#" +
               "\n2 - Desenvolvedor JAVA" +
               "\n3 - Gerente" +
               "\n4 - Lista funcionários" +
               "\n5 - Sair");

                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    var funcionario = new DesenvolvedorJava();
                    Console.WriteLine("Digite o nome do funcionário(a): ");
                    var nomeFuncionario = Console.ReadLine();
                    funcionario.Nome = nomeFuncionario;
                    composite.AdicionarFuncionario(funcionario);
                }

                if (opcao == "2")
                {
                    var funcionario = new DesenvolvedorCSharp();
                    Console.WriteLine("Digite o nome do funcionário(a): ");
                    var nomeFuncionario = Console.ReadLine();
                    funcionario.Nome = nomeFuncionario;
                    composite.AdicionarFuncionario(funcionario);
                }

                if (opcao == "3")
                {
                    var funcionario = new Gerente();
                    Console.WriteLine("Digite o nome do funcionário(a): ");
                    var nomeFuncionario = Console.ReadLine();
                    funcionario.Nome = nomeFuncionario;
                    composite.AdicionarFuncionario(funcionario);
                }

                if (opcao == "4")
                {
                    Console.WriteLine("Aqui estão os funcionários cadastrados");
                    composite.ListarFuncionarios();
                }
            }
        }
    }
}
