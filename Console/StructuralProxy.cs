using DesignPatterns2021.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class StructuralProxy
    {
        public static void Execute()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Cliente: Executando o CodigoCliente com o Sujeito: ");
            Sujeito sujeito = new Sujeito();
            cliente.CodigoCliente(sujeito);

            Console.WriteLine("Cliente: Executando o CodigoCliente com o Proxy: ");
            Proxy proxy = new Proxy(sujeito);
            cliente.CodigoCliente(proxy);

        }
    }
}
