using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.State
{
    public class ClientePrata : PerfilCliente
    {
        public ClientePrata(PerfilCliente perfil) : this(perfil.Balanco, perfil.Cliente) { }

        public ClientePrata(double balanco, Cliente cliente) : base()
        {
            this.balanco = balanco;
            this.cliente = cliente;
            Inicializador();
        }

        private void Inicializador()
        {
            juros = 0.02;
            limite = 5000.00;
            chequeEspecial = 1000.00;
        }

        public override void Depositar(double valor)
        {
            balanco += valor;
            VerificarEstadoAtual();
        }

        public override void PagarJuros()
        {
            balanco += juros * balanco;
            VerificarEstadoAtual();
        }

        public override void Sacar(double valor)
        {
            balanco -= valor;
            VerificarEstadoAtual();
        }

        private void VerificarEstadoAtual()
        {
            if (balanco <= 1000.00)
            {
                cliente.PerfilCliente = new ClienteBronze(this);
            }
            else if (balanco > limite)
            {
                cliente.PerfilCliente = new ClienteOuro(this);
            }
        }
    }
}
