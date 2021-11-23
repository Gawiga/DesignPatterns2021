using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.State
{
    /// <summary>
    /// State pattern
    /// </summary>
    public abstract class PerfilCliente
    {
        protected Cliente cliente;
        protected double balanco;
        protected double juros;
        protected double limite;
        protected double chequeEspecial;

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public double Balanco
        {
            get { return balanco; }
            set { balanco = value; }
        }

        public abstract void Depositar(double valor);
        public abstract void Sacar(double valor);
        public abstract void PagarJuros();

    }
}
