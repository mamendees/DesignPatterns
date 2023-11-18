using FactoryMethod.B.Product;

namespace FactoryMethod.B.Factory;
public class PizzaFactoryBrasil : PizzaFactoryMethod
{
    protected override Pizza CriarPizza(TipoPizza tipoPizza) => tipoPizza switch
    {
        TipoPizza.Mussarela => new PizzaMussarelaBrasil(),
        TipoPizza.Frango => new PizzaFrangoBrasil(),
        _ => throw new InvalidOperationException("Error")
    };
}
