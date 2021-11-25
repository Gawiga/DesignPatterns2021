using DesignPatterns2021.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Adapter : IPadrao
    {
        public void Execute()
        {
            string opcao = "";
            while (opcao != "3")
            {
                //Console.WriteLine("Selecione a voltagem do chuveiro que você deseja:\n1 - 220v\n2 - 110v\n3 - Sair");
                Console.WriteLine("Em qual país você está?\n1 - Brasil\n2 - Estados Unidos\n3 - Sair");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    var geladeira = new ProdutoService(new Geladeira());
                    var result = geladeira.EnviarProduto();
                    Console.WriteLine(result);
                }

                if (opcao == "2")
                {
                    var geladeira = new ProdutoService(new DesignPatterns2021.Structural.Adapter.Adapter(new AdaptadorTomadaAmericana()));
                    var result = geladeira.EnviarProduto();
                    Console.WriteLine(result);
                }
            }
        }
    }
}
