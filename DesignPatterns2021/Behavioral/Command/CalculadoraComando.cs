using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Command
{
    class CalculadoraComando : ComandoAbstrato
    {
        private char _operador;
        private Usuario _usuario;
        private readonly Calculadora _calculadora;


        public CalculadoraComando(Calculadora calculadora, char operador, Usuario usuario)
        {
            _calculadora = calculadora;
            _operador = operador;
            _usuario = usuario;
        }

        public char Operator
        {
            set => _operador = value;
        }

        public override void Executar()
        {
            _calculadora.Operacao(_operador, _usuario);
        }

        public override void Desfazer()
        {
            _calculadora.Operacao(Desfazer(_operador), _usuario);
        }

        private static char Desfazer(char operador)
        {
            switch (operador)
            {
                case 'C': 
                    return 'B';
                case 'B':
                    return 'C';
                case 'D':
                    return 'E';
                case 'E':
                    return 'D';
                default:
                    throw new ArgumentException("Operador desconhecido");
                    break;
            }
        }

    }
}
