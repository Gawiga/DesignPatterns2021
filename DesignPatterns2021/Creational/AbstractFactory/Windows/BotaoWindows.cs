﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Creational.AbstractFactory
{
    //ProductA1
    public class BotaoWindows : IBotao
    {
        public string Valor => "Eu sou um botão do windows";
    }
}
