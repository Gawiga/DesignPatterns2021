using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Strategy
{
    public class Pix : Pagamento
    {
        public bool Processar()
        {
            Console.WriteLine("Processando Pix...");
            return true;
        }
    }
}
