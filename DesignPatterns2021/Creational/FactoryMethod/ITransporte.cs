namespace DesignPatterns2021.Creational.FactoryMethod
{
    public interface ITransporte
    {
        public string EntregarEncomenda(string endereco)
        {
            return $"Sua encomenda foi entregue em {endereco} de {GetType().Name}";
        }
    }
}
