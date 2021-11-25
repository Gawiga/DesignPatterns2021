using DesignPatterns2021.Creational.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class FactoryMethod : IPadrao
    {
        public void Execute()
        {
            string valor = "";
            while (valor != "4")
            {
                Console.WriteLine("Vejo que você é da cidade de São Paulo.\n" +
                    "Para qual cidade deseja realizar sua entrega?\n " +
                    "1 - São Paulo | 2 - Brasília | 3 - Paris | 4 - Sair");

                valor = Console.ReadLine();

                DesignPatterns2021.Creational.FactoryMethod.FactoryMethod _fabrica;

                if (valor.ToString() == "1")
                {
                    _fabrica = new FabricaUrbana();
                    RealizarEntrega(_fabrica, "São Paulo");
                }


                if (valor.ToString() == "2")
                {
                    _fabrica = new FabricaRodoviaria();
                    RealizarEntrega(_fabrica, "Brasília");
                }


                if (valor.ToString() == "3")
                {
                    _fabrica = new FabricaMaritima();
                    RealizarEntrega(_fabrica, "Paris");
                }
            }
        }

        private static void RealizarEntrega(DesignPatterns2021.Creational.FactoryMethod.FactoryMethod _fabrica, string endereco)
        {
            var transporte = _fabrica.ObterTransporte();
            Console.WriteLine("A sua encomenda será entregue de " + transporte.GetType().Name);
            var entrega = transporte.EntregarEncomenda(endereco);
            Console.WriteLine(entrega);
        }
    }
}
