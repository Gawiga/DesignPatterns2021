using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.State
{
    public class ClienteBronze : PerfilCliente
    {
        public ClienteBronze(PerfilCliente perfil) : this(perfil.Balanco, perfil.Cliente) { }

        public ClienteBronze(double balanco, Cliente cliente)
        {
            this.balanco = balanco;
            this.cliente = cliente;
            Inicializador();
        }

        private void Inicializador()
        {
            juros = 0.01;
            limite = 1000.00;
            chequeEspecial = 500.00;
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
            if (balanco > 1000.00)
            {
                cliente.PerfilCliente = new ClientePrata(this);
            }
        }
    }
}
