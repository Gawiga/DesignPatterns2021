using System;

namespace DesignPatternsExecutavel
{
    class Program
    {
        static void Main(string[] args)
        {
            TemplateMethod.Execute();
            //EscolherPadrao();
        }

        static void EscolherPadrao()
        {
            string entrada = MensagemBoasVindas();
            bool ehInteiro = int.TryParse(entrada, out int valorConvertido);

            if (ehInteiro)
            {
                ExecutarPadrao(valorConvertido);
            }
            else
            {
                ValorInvalido();
            }
        }

        private static string MensagemBoasVindas()
        {
            string mensagemBoasVindas = @"--- BEM VINDO AO DESIGN PATTERNS 2021 ---
BEHAVIORAL:
ChainOfResponsability = 1
Command = 2
Interpreter = 3
Iterator = 4
Mediator = 5
Memento = 6
Observer = 7
State = 8
Strategy = 9
TemplateMethod = 10
Visitor = 11

CREATIONAL:
AbstractFactory = 12
Builder = 13
FactoryMethod = 14
Prototype = 15
Singleton = 16

STRUCTURAL
Adapter = 17
Bridge = 18
Composite = 19
Decorator = 20
Facade = 21
Flyweight = 22
Proxy = 23
                
DIGITE O NUMERO QUE DESEJA TESTAR: ";
            Console.WriteLine(mensagemBoasVindas);
            var entrada = Console.ReadLine();
            return entrada;
        }

        private static void ExecutarPadrao(int valorConvertido)
        {
            var padrao = (PadroesEnum)valorConvertido;
            var tipoClasse = Type.GetType("DesignPatternsExecutavel." + padrao.ToString());
            try
            {
                var classe = (IPadrao)Activator.CreateInstance(tipoClasse);
                classe.Execute();
            }
            catch (Exception)
            {
                ValorInvalido();
            }
        }

        private static void ValorInvalido()
        {
            Console.WriteLine("Valor inserido não é válido");
            Console.ReadKey();
            EscolherPadrao();
        }
    }
}
