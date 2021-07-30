using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Bridge
{
    //abstração
    public class ControleRemoto : IRemoto
    {
        protected IAparelho _aparelho;

        public ControleRemoto()
        {

        }

        public ControleRemoto(IAparelho aparelho)
        {
            _aparelho = aparelho;

        }

        public void BotaoAumentarCanal()
        {
            var canal = _aparelho.ObterCanal();

            if (canal < 50)
                _aparelho.DefinirCanal(canal + 1);
            else
                Console.WriteLine("Canal máximo atingido");
        }

        public void BotaoAumentarVolume()
        {
            var volume = _aparelho.ObterVolume();

            if (volume < 50)
                _aparelho.DefinirVolume(volume + 1);
            else
                Console.WriteLine("Volume máximo atingido");
        }

        public void BotaoDiminuirCanal()
        {
            var canal = _aparelho.ObterCanal();

            if (canal < 2)
                Console.WriteLine("Canal mínimo atingido");
            else
                _aparelho.DefinirCanal(canal - 1);
        }

        public void BotaoDiminuirVolume()
        {
            var volume = _aparelho.ObterVolume();

            if (volume < 2)
                Console.WriteLine("Volume minimo atingido");
            else
                _aparelho.DefinirVolume(volume - 1);
        }

        public void BotaoLigar()
        {
            if (_aparelho.EstaLigado())
                _aparelho.Desligar();
            else
                _aparelho.Ligar();
        }
    }
}
