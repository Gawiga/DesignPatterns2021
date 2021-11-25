using DesignPatterns2021.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Proxy : IPadrao
    {
        public void Execute()
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Cliente: Executando o CodigoCliente com o Sujeito: ");
            SujeitoReal sujeito = new SujeitoReal();
            cliente.CodigoCliente(sujeito);

            Console.WriteLine("Cliente: Executando o CodigoCliente com o Proxy: ");
            DesignPatterns2021.Structural.Proxy.Proxy proxy = new DesignPatterns2021.Structural.Proxy.Proxy(sujeito);
            cliente.CodigoCliente(proxy);
        }
    }
}
