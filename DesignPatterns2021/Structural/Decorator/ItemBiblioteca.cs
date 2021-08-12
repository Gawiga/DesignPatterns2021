using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Decorator
{
    /// <summary>
    /// Componente Abstrato - Define a interface para os objetos que 
    /// podem ter responsabilidades adicionadas a eles dinamicamente
    /// </summary>
    public interface ItemBiblioteca
    {
        int NumeroCopias { get; set; }

        public abstract void Exibir();
        
    }
}
