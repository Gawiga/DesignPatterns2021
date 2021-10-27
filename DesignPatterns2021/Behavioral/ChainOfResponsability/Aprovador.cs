using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.ChainOfResponsability
{
    /// <summary>
    /// Handler
    /// </summary>
    public abstract class Aprovador
    {
        protected Aprovador sucessor;

        public void DefinirSuperior(Aprovador sucessor)
        {
            this.sucessor = sucessor;
        }

        public abstract void ProcessarSolicitacao(Compra compra);
    }
}
