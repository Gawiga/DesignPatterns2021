using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Composite
{
    /// <summary>
    /// Composite
    /// </summary>
    public class Mensagem : IMensagem
    {
        private readonly List<IMensagem> _lista = new List<IMensagem>();

        public string Texto { get; set ; }

        public Mensagem(string texto)
        {
            Texto = texto;
        }

        public void AdicionarFilho(IMensagem mensagem)
        {
            _lista.Add(mensagem);
        }

        public void RemoverFilho(IMensagem mensagem)
        {
            _lista.Remove(mensagem);
        }

        public IEnumerable<IMensagem> ObterLista()
        {
            return _lista;
        }

        public void ExibirListaNivelada(int nivel)
        {
            Console.WriteLine(new string('-', nivel) + Texto);

            foreach (var mensagem in _lista)
            {
                mensagem.ExibirListaNivelada(nivel + 2);
            }
        }
    }
}
