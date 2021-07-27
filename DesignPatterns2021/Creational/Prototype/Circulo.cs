using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.Prototype
{
    public class Circulo 
    {
        public int Raio { get; set; }

        public Circulo()
        {

        }

        public Circulo(int raio)
        {
            Raio = raio;
        }

        public Circulo Clone()
        {
            return (Circulo)MemberwiseClone();
        }
    }
}
