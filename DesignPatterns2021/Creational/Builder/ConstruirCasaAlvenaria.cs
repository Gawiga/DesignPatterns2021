using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.Builder
{
    public class ConstruirCasaAlvenaria : IBuilder
    {
        private CasaAlvenaria _casaAlvenaria = new CasaAlvenaria();

        public ConstruirCasaAlvenaria()
        {
            Reset();
        }

        public void ConstruirJanelas()
        {
            _casaAlvenaria.JanelaPronta = true;
        }

        public void ConstruirParedes()
        {
            _casaAlvenaria.ParedePronta = true;
        }

        public void ConstruirPortas()
        {
            _casaAlvenaria.PortaPronta = true;
        }

        public void ConstruirTelhado()
        {
            _casaAlvenaria.TelhadoPronto = true;
        }

        public void Reset()
        {
            _casaAlvenaria = new CasaAlvenaria();
        }

        public CasaAlvenaria ObterCasaAlvenaria()
        {
            return _casaAlvenaria;
        }
    }
}
