using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.Builder
{
    public class ConstruirCasaPapel : IBuilder
    {
        private CasaPapel _casaPapel = new CasaPapel();

        public void ConstruirJanelas()
        {
            _casaPapel.JanelaPronta = true;
        }

        public void ConstruirParedes()
        {
            _casaPapel.ParedePronta = true;
        }

        public void ConstruirPortas()
        {
            _casaPapel.PortaPronta = true;
        }

        public void ConstruirTelhado()
        {
            _casaPapel.TelhadoPronto = true;
            _casaPapel.DobraPronta = true;
        }

        public void Reset()
        {
            _casaPapel = new CasaPapel();
        }

        public CasaPapel ObterCasaPapel()
        {
            return _casaPapel;
        }
    }
}
