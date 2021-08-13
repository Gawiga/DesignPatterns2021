using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Facade
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
        }
    }
}
