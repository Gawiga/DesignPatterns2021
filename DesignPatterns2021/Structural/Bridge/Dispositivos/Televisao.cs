using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Bridge
{
    public class Televisao : IAparelho
    {
        private bool ligado = false;
        private int volume = 30;
        private int canal = 1;

        public bool EstaLigado()
        {
            return ligado;
        }

        public void DefinirCanal(int valor)
        {
            canal = valor;
            Console.WriteLine("Canal " + canal);
        }

        public void DefinirVolume(int valor)
        {
            volume = valor;
            Console.WriteLine("Volume " + volume);
        }

        public void Desligar()
        {
            Console.WriteLine("Desligando o aparelho");
            ligado = false;
        }

        public void Ligar()
        {
            ligado = true;
            Console.WriteLine("Ligando o aparelho");
        }

        public int ObterCanal()
        {
            return canal;
        }

        public int ObterVolume()
        {
            return volume;
        }
    }
}
