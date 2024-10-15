namespace DesignPatterns2021.Creational.FactoryMethod;

/// <summary>
/// Creator Class declara o FactoryMethod que deve retornar um objeto do tipo uma classe ITransporte
/// 
/// </summary>
public abstract class FactoryMethodCreator
{
    /// <summary>
    /// Alem de criar um transporte, o FactoryMethod pode ter outras responsabilidades
    /// </summary>
    /// <returns></returns>
    public string ObterEndereco()
    {
        return "Endereço";
    }

    public abstract ITransporte ObterTransporte();

}
