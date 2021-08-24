using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Proxy
{
    public class Cliente
    {
        /// <summary>
        /// O CodigoCliente deveria funcionar com todos objetos 
        /// (tanto sujeitos e proxies) através da interface ISujeito para suportar
        /// sujeitos e proxies. Na vida real, entretanto, Clients na maioria das vezes
        /// trabalhar com os sujeitos reais. Neste caso, para implementar esse padrão mais 
        /// facilmente, você pode extender seu proxy através da classe sujeito real.
        /// </summary>
        /// <param name="sujeito"></param>
        public void CodigoCliente(ISujeito sujeito)
        {
            sujeito.Requisicao();
        }

    }
}
