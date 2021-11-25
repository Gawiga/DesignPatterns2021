using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Interpreter
{
    /// <summary>
    /// This is a joke
    /// I just added to have THE 23 GoF patterns
    /// http://blogs.perl.org/users/jeffrey_kegler/2013/03/the-interpreter-design-pattern.html
    /// </summary>
    public class Context
    {
        string input;
        int output;

        public Context(string input)
        {
            this.input = input;
        }

        public string Input
        {
            get { return input; }
            set { input = value; }
        }

        public int Output
        {
            get { return output; }
            set { output = value; }
        }

    }
}
