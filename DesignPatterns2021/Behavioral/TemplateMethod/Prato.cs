using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Behavioral.TemplateMethod
{
    public abstract class Prato
    {
        /// <summary>
        /// Template Method
        /// </summary>
        public void ServirRefeicaoCompleta()
        {
            Entrada();
            CozinharComida();
            MontarPrato();
            Sobremesa();
        }

        protected abstract void CozinharComida();
        protected abstract void MontarPrato();

        /// <summary>
        /// Podemos também ter HOOKS
        /// Subclasses podem sobreescreve-los, mas não são obrigadas, já que eles já possuem um valor padrão
        /// </summary>
        protected virtual void Entrada()
        {
            Console.WriteLine("Servindo entrada padrão!");
        }

        protected virtual void Sobremesa() 
        {
            Console.WriteLine("Servindo sobremesa padrão!");
        }
    }
}
