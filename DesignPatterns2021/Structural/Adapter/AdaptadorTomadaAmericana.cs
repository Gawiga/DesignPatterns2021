using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Adapter
{
    //Classe adaptada
    public class AdaptadorTomadaAmericana : IAdaptadorTomadaAmericana
    {
        public string Conectar()
        {
            return "Adaptador para tomadas americanas conectado!"; 
        }
    }
}
