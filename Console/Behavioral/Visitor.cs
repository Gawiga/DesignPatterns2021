﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Visitor : IPadrao
    {
        public void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("Visitor!");
                opcao = Console.ReadLine();

            }
        }
    }
}
