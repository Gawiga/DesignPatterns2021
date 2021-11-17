using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Mediator
{
    public class SalaChatConcreta : SalaChat
    {
        private Dictionary<string, Participante> participantes = new Dictionary<string, Participante>();

        public override void Registrar(Participante participante)
        {
            if (!participantes.ContainsValue(participante))
            {
                participantes[participante.Nome] = participante;
            }

            Console.WriteLine("{0} entrou!", participante.Nome);
            participante.SalaChat = this;
        }


        public override void EnviarMensagem(string remetente, string destinatario, string mensagem)
        {
            Participante participante = participantes[destinatario];

            if (participante != null)
            {
                participante.ReceberMensagem(remetente, mensagem);
            }
        }
    }
}
