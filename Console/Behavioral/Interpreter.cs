using DesignPatterns2021.Behavioral.Interpreter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExecutavel
{
    class Interpreter : IPadrao
    {
        public void Execute()
        {
            var opcao = "";

            while (opcao != "9")
            {
                Console.WriteLine("Digite 9 para sair!\n");
                opcao = Console.ReadLine();

                string roman = "MMXXI";
                Context context = new Context(roman);
                
                // Build the 'parse tree'
                List<Expression> tree = new List<Expression>();
                tree.Add(new ExpressionMil());
                tree.Add(new ExpressionCem());
                tree.Add(new ExpressionDez());
                tree.Add(new ExpressionUm());
                
                // Interpret
                foreach (Expression exp in tree)
                {
                    exp.Interpret(context);
                }
                Console.WriteLine("{0} = {1}", roman, context.Output);
            }
        }
    }
}
