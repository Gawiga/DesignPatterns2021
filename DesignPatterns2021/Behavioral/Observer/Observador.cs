using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Observer
{
    /// <summary>
    /// Troquei aqui a forma de cadastrar interfaces
    /// Conversei com o Uncle Bob e ele disse para evitar prefixo e usar mais sufixos
    /// Ao invés de IClass usar ClasseConcreta
    /// </summary>
    public interface Observador
    {
        public void Atualizar();
    }
}
