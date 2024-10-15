using DesignPatterns2021.Structural.Composite;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Composite : IPadraoExecutavel
    {
        public void Execute()
        {
            /// <summary>
            /// Mensagem -> Nível 0
            ///   Mensagem de Erro -> Nível 1
            ///     Mensagem de Aviso -> Nível 2    
            ///       Mensagem de Info -> Nível 3
            /// </summary>
            var mensagemInfo = new MensagemInfo("Mensagem Nível 4a");
            var mensagemInfo2 = new MensagemInfo("Mensagem Nível 4aa");

            var compositorMensagemInfo = new Mensagem("Nível 3a");
            compositorMensagemInfo.AdicionarFilho(mensagemInfo);
            compositorMensagemInfo.AdicionarFilho(mensagemInfo2);

            var mensagemAviso = new MensagemAviso("Mensagem Nível 3a");
            var mensagemAviso2 = new MensagemAviso("Mensagem Nível 3aa");

            var compositorMensagemAviso = new Mensagem("Nível 2a");
            compositorMensagemAviso.AdicionarFilho(compositorMensagemInfo);
            compositorMensagemAviso.AdicionarFilho(mensagemAviso);
            compositorMensagemAviso.AdicionarFilho(mensagemAviso2);

            var mensagemErro = new MensagemErro("Mensagem Nível 2a");
            
            var compositorMensagemErro = new Mensagem("Nível 1a");
            compositorMensagemErro.AdicionarFilho(compositorMensagemAviso);
            compositorMensagemErro.AdicionarFilho(mensagemErro);

            var mensagem = new Mensagem("Nível 0");
            mensagem.AdicionarFilho(compositorMensagemErro);

            var mensagemInfo3 = new MensagemInfo("Mensagem Nível 4b");

            var _compositorMensagemInfo = new Mensagem("Nível 3b");
            _compositorMensagemInfo.AdicionarFilho(mensagemInfo3);

            var mensagemAviso3 = new MensagemAviso("Mensagem Nível 3b");
            var mensagemAviso4 = new MensagemAviso("Mensagem Nível 3bb");

            var _compositorMensagemAviso = new Mensagem("Nível 2b");
            _compositorMensagemAviso.AdicionarFilho(_compositorMensagemInfo);
            _compositorMensagemAviso.AdicionarFilho(mensagemAviso3);
            _compositorMensagemAviso.AdicionarFilho(mensagemAviso4);
            
            var mensagemErro2 = new MensagemErro("Mensagem Nível 2b");
            
            var _compositorMensagemErro = new Mensagem("Nível 1b");
            _compositorMensagemErro.AdicionarFilho(_compositorMensagemAviso);
            _compositorMensagemErro.AdicionarFilho(mensagemErro2);

            mensagem.AdicionarFilho(_compositorMensagemErro);

            mensagem.ExibirListaNivelada(0);
        }

    }
}
