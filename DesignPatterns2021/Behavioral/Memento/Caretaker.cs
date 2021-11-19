using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.Memento
{
    public class Caretaker
    {
        Lembranca memento;

        public Lembranca Memento
        {
            get { return memento; }
            set { memento = value; }
        }
    }
}
