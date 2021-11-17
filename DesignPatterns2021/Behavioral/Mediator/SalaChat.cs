using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Mediator
{
    /// <summary>
    /// Abstract Mediator
    /// </summary>
    public abstract class SalaChat
    {
        public abstract void Registrar(Participante participante);
        public abstract void EnviarMensagem(string remetente, string destinatario, string mensagem);
    }
}
