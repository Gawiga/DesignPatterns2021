using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Proxy
{
    public class Proxy : ISujeito
    {
        private Sujeito _sujeito;

        public Proxy(Sujeito sujeito)        
        {
            _sujeito = sujeito;
        }

        /// <summary>
        /// As utilizações mais comuns de proxy, são o lazy load, cache, controlar acesso, log, etc.
        /// Um proxy pode executar uma dessas coisas e então, dependendo do resultado, passar
        /// a execução para o mesmo métodos em um objeto Sujeito Concreto
        /// </summary>
        public void Requisicao()
        {
            if (VerificaAcesso())
            {
                _sujeito.Requisicao();


            }
            throw new NotImplementedException();
        }

        public bool VerificaAcesso()
        {
            // Verificação real deve ser feita aqui
            Console.WriteLine("Proxy: Verificando o acesso antes de disparar um pedido.");
            return true;
        }

        public void LogDeAcesso()
        {
            Console.WriteLine("Proxy: Logando a requsição.");
        }
    }
}
