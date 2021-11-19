using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatterns2021.Behavioral.Memento
{
    /// <summary>
    /// Memento
    /// </summary>
    public class Lembranca
    {
        string nome;
        string telefone;
        double orcamento;

        public Lembranca(string nome, string telefone, double orcamento)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.orcamento = orcamento;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public double Orcamento
        {
            get { return orcamento; }
            set { orcamento = value; }
        }

    }
}
