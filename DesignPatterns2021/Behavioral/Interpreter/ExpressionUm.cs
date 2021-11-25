using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Interpreter
{
    public class ExpressionUm : Expression
    {
        public override string One() { return "I"; }
        public override string Four() { return "IV"; }
        public override string Five() { return "V"; }
        public override string Nine() { return "IX"; }
        public override int Multiplier() { return 1; }
    }
}
