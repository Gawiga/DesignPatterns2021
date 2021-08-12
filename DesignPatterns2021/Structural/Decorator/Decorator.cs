using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Decorator
{
    /// <summary>
    /// Decorator - Mantem uma referência para um Componente Abstrato e 
    /// define uma interface de acordo com a interface do Componente
    /// </summary>
    public abstract class Decorator : ItemBiblioteca
    {
        public int NumeroCopias { get; set; }
        
        protected ItemBiblioteca itemBiblioteca;

        public Decorator(ItemBiblioteca _itemBiblioteca)
        {
            itemBiblioteca = _itemBiblioteca;
        }

        public abstract void Exibir();

    }
}
