using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Iterator
{
    /// <summary>
    /// ConcreteCollection
    /// </summary>
    public class PalavrasCollection : IteratorAggregate
    {
        readonly List<string> palavras = new List<string>();

        bool direcao = false;

        public void DirecaoReversa()
        {
            direcao = !direcao;
        }

        public List<string> GetItems()
        {
            return palavras;
        }

        public void AddItem(string item)
        {
            palavras.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlfabetoIterator(this, direcao);
        }
    }
}
