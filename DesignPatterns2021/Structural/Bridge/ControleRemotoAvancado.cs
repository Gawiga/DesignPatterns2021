using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Bridge
{
    //abstração extendida
    public class ControleRemotoAvancado : ControleRemoto
    {
        public ControleRemotoAvancado(IAparelho aparelho)
        {
            base._aparelho = aparelho;
        }

        public void Mute()
        {
            var volume = _aparelho.ObterVolume();

            if (volume != 0)
            {
                _aparelho.DefinirVolume(0);
                Console.WriteLine("Mutando o aparelho...");
            } else
            {
                _aparelho.DefinirVolume(10);
                Console.WriteLine("Desmutando o aparelho...");
            }
            
        }
    }
}
