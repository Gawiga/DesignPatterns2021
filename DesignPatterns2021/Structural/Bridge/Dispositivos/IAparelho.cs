using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Bridge
{
    public interface IAparelho
    {
        bool EstaLigado();
        void Ligar();
        void Desligar();
        void DefinirVolume(int valor);
        void DefinirCanal(int valor);
        int ObterCanal();
        int ObterVolume();
    }
}
