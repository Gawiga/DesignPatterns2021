using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Proxy
{
    /// <summary>
    /// O Sujeito concreto contem  
    /// </summary>
    public class SujeitoReal : ISujeito
    {
        public void Requisicao()
        {
            Console.WriteLine("Sujeito: Manipulando a requsição!");
        }
    }
}
