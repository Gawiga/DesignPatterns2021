using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Composite
{
    /// <summary>
    /// Componente
    /// </summary>
    public interface IMensagem
    {
        string Texto { get; set; }
        void ExibirListaNivelada(int nivel);
    }
}
