using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.Builder
{
    public class ConstruirCasaMadeira : IBuilder
    {
        private CasaMadeira _casaMadeira = new CasaMadeira();

        public ConstruirCasaMadeira()
        {
            Reset();
        }
        public void ConstruirJanelas()
        {
            _casaMadeira.JanelaPronta = true;
        }

        public void ConstruirParedes()
        {
            _casaMadeira.ParedePronta = true;
            _casaMadeira.VenizPronto = true;
        }

        public void ConstruirPortas()
        {
            _casaMadeira.PortaPronta = true;
        }

        public void ConstruirTelhado()
        {
            _casaMadeira.TelhadoPronto = true;
        }

        public void Reset()
        {
            _casaMadeira = new CasaMadeira();            
        }

        public CasaMadeira ObterCasaMadeira()
        {
            return _casaMadeira;
        }
    }
}
