using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Observer
{
    public class ObservadorConcreto : Observador
    {
        private string nome;
        private string estadoObservador;
        private SujeitoConcreto sujeito;

        public ObservadorConcreto(SujeitoConcreto sujeito, string nome)
        {
            this.sujeito = sujeito;
            this.nome = nome;
        }

        public void Atualizar()
        {
            estadoObservador = sujeito.EstadoSujeito;
            Console.WriteLine("Sujeito {0} Estado {1} ", nome, estadoObservador);
        }

        public SujeitoConcreto Sujeito
        {
            get { return sujeito; }
            set { sujeito = value; }
        }
    }
}
