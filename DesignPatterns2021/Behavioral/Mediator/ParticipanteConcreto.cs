using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Mediator
{
    public class ParticipanteConcreto : Participante
    {
        public ParticipanteConcreto(string nome) : base(nome) { }


        public override void ReceberMensagem(string destinatario, string mensagem)
        {
            base.ReceberMensagem(destinatario, mensagem);
        }
    }
}
