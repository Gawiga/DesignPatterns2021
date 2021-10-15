using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Command
{
    internal abstract class ComandoAbstrato
    {
        public abstract void Executar();
        public abstract void Desfazer();
    }
}
