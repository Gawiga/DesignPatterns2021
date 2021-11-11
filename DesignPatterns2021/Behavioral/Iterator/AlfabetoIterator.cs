using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Iterator
{
    /// <summary>
    /// ConcreteIterator
    /// </summary>
    public class AlfabetoIterator : Iterator
    {
        private PalavrasCollection palavras;

        private int posicao = -1;

        private bool reverso = false;

        public AlfabetoIterator(PalavrasCollection palavras, bool reverso = false)
        {
            this.palavras = palavras;
            this.reverso = reverso;

            if (reverso)
            {
                posicao = palavras.GetItems().Count;
            }
        }

        public override object Current()
        {
            return palavras.GetItems()[posicao];
        }

        public override int Key()
        {
            return posicao;
        }

        public override bool MoveNext()
        {
            int posicaoAtualizada = posicao + (reverso ? -1 : 1);

            if (posicaoAtualizada >= 0 && posicaoAtualizada < palavras.GetItems().Count)
            {
                posicao = posicaoAtualizada;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            posicao = reverso ? palavras.GetItems().Count - 1 : 0;
        }
    }
}
