using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Mediator
{
    public abstract class Participante
    {
        SalaChat salaChat;
        string nome;

        public Participante(string nome)
        {
            this.nome = nome;
        }

        public string Nome
        {
            get { return nome; }
        }

        public SalaChat SalaChat
        {
            set { salaChat = value; }
            get { return salaChat; }
        }

        public void EnviarMensagem(string destinatario, string mensagem)
        {
            salaChat.EnviarMensagem(nome, destinatario, mensagem);
        }

        public virtual void ReceberMensagem(string destinatario, string mensagem)
        {
            Console.WriteLine("{0} para {1}: '{2}'", destinatario, Nome, mensagem);
        }
    }
}
