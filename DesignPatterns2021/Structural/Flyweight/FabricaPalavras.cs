using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Flyweight
{
    /// <summary>
    /// FlyweightFactory
    /// </summary>
    public class FabricaPalavras
    {
        private Dictionary<char, Palavra> palavras = new Dictionary<char, Palavra>();

        public Palavra ObterPalavras(char chave)
        {
            //usa inicialização lenta
            Palavra palavra = null;

            /* Aqui está a sacada do flyweight, se o objeto já foi inicializado,
            eu adiciono esse mesmo objeto no meu array, evitando o consumo de RAM
            para instanciar um novo objeto que vai ter o mesmo resultado */
            if (palavras.ContainsKey(chave))
            {
                palavra = palavras[chave];
            }
            else
            {
                switch (chave)
                {
                    case 'A': 
                        palavra = new PalavraA();
                        break;
                    case 'B':
                        palavra = new PalavraB();
                        break;
                    case 'Z':
                        palavra = new PalavraZ();
                        break;
                }
                palavras.Add(chave, palavra);
            }

            return palavra;
        }
    }
}
