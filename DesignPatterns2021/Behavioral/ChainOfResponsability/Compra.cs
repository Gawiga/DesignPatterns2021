using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.ChainOfResponsability
{
    /// <summary>
    /// Classe lidando com a requisição
    /// </summary>
    public class Compra
    {
        private int numero;
        private double total;
        private string proposito;

        public Compra(int numero, double total, string proposito)
        {
            this.numero = numero;
            this.total = total;
            this.proposito = proposito;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double Total
        {
            get { return total; }
            set { total = value; }
        }

        public string Proposito
        {
            get { return proposito; }
            set { proposito = value; }
        }
    }
}
