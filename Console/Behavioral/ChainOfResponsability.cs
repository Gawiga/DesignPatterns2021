using DesignPatterns2021.Behavioral.ChainOfResponsability;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class ChainOfResponsability : IPadrao
    {
        public void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("Digite 9 para sair!");
                opcao = Console.ReadLine();

                // Definindo a corrente da configuração de Chain of Responsability 
                var joao = new Presidente();
                var pedro = new VicePresidente();
                var diretor = new Diretor();

                diretor.DefinirSuperior(pedro);
                pedro.DefinirSuperior(joao);

                // Processando compras
                var canetas = new Compra(1, 300.0, "Canetas");
                diretor.ProcessarSolicitacao(canetas);

                var cadeiras = new Compra(2, 3000.0, "Cadeiras");
                diretor.ProcessarSolicitacao(cadeiras);

                var carro = new Compra(3, 20000.0, "Carro");
                diretor.ProcessarSolicitacao(carro);

                var cadernos = new Compra(1, 300.0, "Cadernos");
                diretor.ProcessarSolicitacao(cadernos);

                var escritorio = new Compra(4, 50000.0, "Novo Escritório");
                diretor.ProcessarSolicitacao(escritorio);
            }
        }
    }
}
