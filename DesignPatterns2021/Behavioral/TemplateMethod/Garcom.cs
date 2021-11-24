using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.TemplateMethod
{
    public class Garcom
    {
        /// <summary>
        /// A classe cliente chama o Template Method para executar o algoritmo
        /// A classe cliente não tem que saber qual a classe concreta que o objeto está trabalhando
        /// </summary>
        /// <param name="prato"></param>
        public static void ServirPrato(Prato prato)
        {
            prato.ServirRefeicaoCompleta();
        }
    }
}
