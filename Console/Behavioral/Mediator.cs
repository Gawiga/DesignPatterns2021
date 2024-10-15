using DesignPatterns2021.Behavioral.Mediator;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Mediator : IPadraoExecutavel
    {
        public void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.Write("Digite seu nome: ");
                var nome = Console.ReadLine();

                var salaChat = new SalaChatConcreta();
                var novoParticipante = new ParticipanteConcreto(nome);
                var regina = new ParticipanteConcreto("Regina");
                var carlos = new ParticipanteConcreto("Carlos");
                var valdemar = new ParticipanteConcreto("Valdemar");

                salaChat.Registrar(novoParticipante);
                salaChat.Registrar(regina);

                regina.EnviarMensagem(novoParticipante.Nome, "Oi... tudo bem com você? ;)");
                Console.Write("Mande sua mensagem para Regina: ");
                var mensagemParaRegina = Console.ReadLine();

                salaChat.Registrar(carlos);
                salaChat.Registrar(valdemar);
                novoParticipante.EnviarMensagem(regina.Nome, mensagemParaRegina);

                carlos.EnviarMensagem(novoParticipante.Nome, "Que isso!!! :o");
                valdemar.EnviarMensagem(novoParticipante.Nome, "Eita cabra! Vou pegar minha peixeira aqui!!!! :@");

                Console.WriteLine("Digite 9 para sair!");
                opcao = Console.ReadLine();

            }
        }
    }
}
