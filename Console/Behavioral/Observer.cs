using DesignPatterns2021.Behavioral.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Observer
    {
        public static void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("Digite 9 para sair ou qualquer tecla para continuar");
                opcao = Console.ReadLine();

                var sujeito = new SujeitoConcreto();
                var observadorA = new ObservadorConcreto(sujeito, "A");
                var observadorB = new ObservadorConcreto(sujeito, "B");
                sujeito.Adicionar(observadorA);
                sujeito.Adicionar(observadorB);

                sujeito.Notificar();

                // Removo observador B da minha lista de notificação
                sujeito.Remover(observadorB);

                sujeito.Adicionar(new ObservadorConcreto(sujeito, "C"));
                sujeito.Adicionar(new ObservadorConcreto(sujeito, "D"));

                // Adiciono a mensagem
                sujeito.EstadoSujeito = "Produto entregue";

                // Notifico todos os observador do meu subject
                sujeito.Notificar();

            }
        }
    }
}
