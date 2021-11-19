using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Memento
{
    public class ProspectoVenda
    {
        string nome;
        string telefone;
        double orcamento;

        public string Nome
        {
            get { return nome; }
            set
            {
                nome = value;
                Console.WriteLine("Nome: " + nome);
            }
        }

        public string Telefone
        {
            get { return telefone; }
            set
            {
                telefone = value;
                Console.WriteLine("Telefone: " + telefone);
            }
        }

        public double Orcamento
        {
            get { return orcamento; }
            set
            {
                orcamento = value;
                Console.WriteLine("Orçamento: " + orcamento);
            }
        }

        public Lembranca SalvarLembranca()
        {
            Console.WriteLine("\nSalvando o estado...\n");
            return new Lembranca(nome, telefone, orcamento);
        }

        public void RestaurarLembranca(Lembranca memento)
        {
            Console.WriteLine("\nRestaurando estado...\n");
            Nome = memento.Nome;
            Telefone = memento.Telefone;
            Orcamento = memento.Orcamento;
        }
    }
}
