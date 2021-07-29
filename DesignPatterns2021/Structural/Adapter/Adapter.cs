using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Adapter
{
    public class Adapter : ICaboEletrico
    {
        private readonly IAdaptadorTomadaAmericana _tomadaAmericana;

        public Adapter(IAdaptadorTomadaAmericana tomadaAmericana)
        {
            _tomadaAmericana = tomadaAmericana;
        }

        public string ConectarCaboEletricoAoProduto()
        {
            return "Cabo no padrão NBR 14136 conectado ao produto com sucesso!\n" 
                + _tomadaAmericana.Conectar();
        }
    }
}
