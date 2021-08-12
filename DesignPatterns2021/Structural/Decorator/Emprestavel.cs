using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Decorator
{
    /// <summary>
    /// Decorator Concreto
    /// Adiciona responsabilidades ao componente
    /// </summary>
    public class Emprestavel : Decorator
    {
        protected readonly List<string> mutuarios = new List<string>();

        public Emprestavel(ItemBiblioteca _itemBiblioteca) : base(_itemBiblioteca) 
        {
        }

        public void ObterItemEmprestado(string nome)
        {
            mutuarios.Add(nome);
            itemBiblioteca.NumeroCopias--;
        }

        public void DevolverItemEmprestado(string nome)
        {
            mutuarios.Remove(nome);
            itemBiblioteca.NumeroCopias++;
        }

        public override void Exibir()
        {
            foreach (var mutuario in mutuarios)
            {
                Console.WriteLine("Mutuario: " + mutuario);
                Console.WriteLine("Copias restantes: " + itemBiblioteca.NumeroCopias);
            }
        }
    }
}
