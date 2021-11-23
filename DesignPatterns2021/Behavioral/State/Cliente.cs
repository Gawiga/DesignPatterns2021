using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.State
{
    public class Cliente
    {
        private PerfilCliente perfilCliente;
        private string titular;

        public Cliente(string titular)
        {
            // contas novas são bronze por padrão
            this.titular = titular;
            this.perfilCliente = new ClienteBronze(0.0, this);
        }

        public double Balanco
        {
            get { return perfilCliente.Balanco; }
        }

        public PerfilCliente PerfilCliente
        {
            get { return perfilCliente; }
            set { perfilCliente = value; }
        }

        public void Depositar(double valor)
        {
            perfilCliente.Depositar(valor);
            Console.WriteLine("Depositado: {0:C}", valor);
            Console.WriteLine("Seu balanço é de {0:C}", this.Balanco);
            Console.WriteLine("Seu perfil agora é {0}", this.perfilCliente.GetType().Name);
        }

        public void Sacar(double valor)
        {
            perfilCliente.Sacar(valor);
            Console.WriteLine("Sacado: {0:C}", valor);
            Console.WriteLine("Seu balanço é de {0:C}", this.Balanco);
            Console.WriteLine("Seu perfil agora é {0}", this.perfilCliente.GetType().Name);
        }

        public void PagarJuros()
        {
            perfilCliente.PagarJuros();
            Console.WriteLine("Juros pago!");
            Console.WriteLine("Seu balanço é de {0:C}", this.Balanco);
            Console.WriteLine("Seu perfil agora é {0}", this.perfilCliente.GetType().Name);
        }
    }
}
