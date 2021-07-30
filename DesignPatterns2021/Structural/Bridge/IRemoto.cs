using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Bridge
{
    //Interface da Implementação
    interface IRemoto 
    {
        void BotaoLigar();
        void BotaoAumentarVolume();
        void BotaoDiminuirVolume();
        void BotaoAumentarCanal();
        void BotaoDiminuirCanal();
    }
}
