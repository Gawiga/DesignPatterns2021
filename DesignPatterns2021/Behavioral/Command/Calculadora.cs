using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Command
{
    internal class Calculadora
    {
        public void Operacao(char operador, Usuario usuario)
        {
            switch (operador)
            {
                case 'C':
                    usuario.Y++;
                    break;
                case 'B':
                    usuario.Y--;
                    break;
                case 'D':
                    usuario.X++;
                    break;
                case 'E':
                    usuario.X--;
                    break;
                default:
                    break;
            }
            Console.WriteLine("A posição atual é ({0},{1})", usuario.X, usuario.Y);
        }


    }
}
