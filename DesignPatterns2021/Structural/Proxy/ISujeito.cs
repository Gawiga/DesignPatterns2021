using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Proxy
{
    /// <summary>
    /// A interface do Sujeto declara as operações comuns para Sujeito e Proxy
    /// Contanto que o cliente trabalhe com o Sujeito Concreto, você será capaz
    /// um proxy ao invés do sujeito concreto
    /// </summary>
    public interface ISujeito
    {
        void Requisicao();
    }
}
