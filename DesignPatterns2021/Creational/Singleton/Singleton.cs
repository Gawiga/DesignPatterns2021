namespace DesignPatterns2021.Creational.Singleton
{
    //O método ObterInstancia serve como uma alternativa ao construtor
    //Deixando assim que os clientes acessem a MESMA instância da classe
    public class Singleton
    {
        // O construtor do Singleton deve sempre ser privado
        // para previnir que ele crie uma nova instância através do `NEW`
        private Singleton() { }

        // Objeto lock será usado para sincronizar as threads durante o primeiro acesso
        private static readonly object _lock = new object();

        // A instância do Singleton é armazeda em um campo estático
        private static Singleton _conexaoBanco;

        public static Singleton ObterInstancia(string valor)
        {
            // Condição necessário para previnir que thread colidam no lock uma vez que ele foi iniciado
            if (_conexaoBanco == null)
            {
                // previne que outras threads sigam adiante
                lock (_lock)
                {
                    // a primeira thread passa pelo lock e cria uma instância
                    if (_conexaoBanco == null)
                    {
                        _conexaoBanco = new Singleton
                        {
                            Valor = valor
                        };
                    }
                }
            }
            return _conexaoBanco;
        }

        // essa propriedade prova que nosso singleton está funcionando
        public string Valor { get; set; }
    }
}
