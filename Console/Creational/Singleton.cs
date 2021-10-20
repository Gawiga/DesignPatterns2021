using DesignPatterns2021.Creational.Singleton;
using System;
using System.Threading;

namespace DesignPatternsExecutavel
{
    class Singleton
    {
        public static void Execute()
        {
            Console.WriteLine(
                "{0}\n{1}\n\n{2}\n",
                "Se o valores exibidos forem iguais, então o padrão Singleton está sendo usado! :)",
                "Se o valores forem diferentes, então estamos criando duas classes! :(",
                "RESULT:"
            );

            Thread conectarPostgres = new Thread(() =>
            {
                ConectarBanco("POSTGRES");
            });


            conectarPostgres.Start();
            conectarPostgres.Join();

            Thread conectarSQL = new Thread(() =>
            {
                ConectarBanco("SQL");
            });

            conectarSQL.Start();
            conectarSQL.Join();
        }

        public static void ConectarBanco(string value)
        {
            DesignPatterns2021.Creational.Singleton.Singleton singleton = DesignPatterns2021.Creational.Singleton.Singleton.ObterInstancia(value);
            Console.WriteLine(singleton.Valor);
        }
    }
}
