﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class BehavioralTemplateMethod
    {
        public static void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("");
                opcao = Console.ReadLine();

            }
        }
    }
}
