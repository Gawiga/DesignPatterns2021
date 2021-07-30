using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Bridge
{
    public class Radio : IAparelho
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
            ligado = false;
            Console.WriteLine("Aparelho desligado");
        }

        public void Ligar()
        {
            ligado = true;
            Console.WriteLine("Aparelho ligado");
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
