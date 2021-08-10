using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns2021.Structural.Composite
{
    public class Composite : FuncionarioAbstrato
    {
        private readonly List<FuncionarioAbstrato> funcionarios = new List<FuncionarioAbstrato>();

        public void AdicionarFuncionario(FuncionarioAbstrato funcionario)
        {
            funcionarios.Add(funcionario);
        }

        public void RemoverFuncionario(FuncionarioAbstrato funcionario)
        {
            funcionarios.Remove(funcionario);
        }

        public void ListarFuncionarios()
        {
            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine("FUNCIONARIO(A): " + funcionario.Nome);
            }
        }

    }
}
