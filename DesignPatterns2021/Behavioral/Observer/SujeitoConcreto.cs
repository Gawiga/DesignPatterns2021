using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Observer
{
    public class SujeitoConcreto : Sujeito
    {
        private string estadoSujeito;

        public string EstadoSujeito
        {
            get { return estadoSujeito; }
            set { estadoSujeito = value; }
        }
    }
}
