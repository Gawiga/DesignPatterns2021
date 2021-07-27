using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.Prototype
{
    public class Retangulo
    {
        public int Largura { get; set; }
        public int Altura { get; set; }

        public Retangulo() { }

        public Retangulo(Retangulo retangulo)
        {
            if(retangulo != null)
            {
                Altura = retangulo.Altura;
                Largura = retangulo.Largura;
            }
        }

        public Retangulo Clone()
        {
            return (Retangulo)MemberwiseClone();
        }
    }
}
