
using FactoryMethod.B.Product;

namespace FactoryMethod.B.Factory;
public class PizzaFactoryItalia : PizzaFactoryMethod
{
    protected override Pizza CriarPizza(TipoPizza tipoPizza) => tipoPizza switch
    {
        TipoPizza.Mussarela => new PizzaMussarelaItalia(),
        TipoPizza.Frango => new PizzaFrangoItalia(),
        _ => throw new InvalidOperationException("Error")
    };
}
