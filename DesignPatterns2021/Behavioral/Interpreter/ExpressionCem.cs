﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Interpreter
{
    public class ExpressionCem : Expression
    {
        public override string One() { return "C"; }
        public override string Four() { return "CD"; }
        public override string Five() { return "D"; }
        public override string Nine() { return "CM"; }
        public override int Multiplier() { return 100; }
    }
}
