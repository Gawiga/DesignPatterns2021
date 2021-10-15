using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Command
{
    public class Usuario
    {
        public int X { get; set; }
        public int Y { get; set; }

        private readonly Calculadora _calculadora = new Calculadora();
        private readonly List<ComandoAbstrato> _commands = new List<ComandoAbstrato>();
        private int _total;

        public void Adicionar(char operador)
        {
            ComandoAbstrato command = new CalculadoraComando(_calculadora, operador, this);
            command.Executar();

            _commands.Add(command);
            _total++;
        }

        public void Retornar(int niveis)
        {
            Console.WriteLine("\n---- Retornando {0} níveis ", niveis);

            for (var i = 0; i < niveis; i++)
            {
                if (_total >= _commands.Count - 1) continue;
                var command = _commands[_total++];
                command.Executar();
            }
        }

        public void Desfazer(int niveis)
        {
            Console.WriteLine("\n---- Desfazendo {0} níveis ", niveis);

            for (var i = 0; i < niveis; i++)
            {
                if (_total <= 0) continue;
                var command = _commands[--_total];
                command.Desfazer();
            }
        }
    }
}
