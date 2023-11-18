using FactoryMethod.B.Product;

namespace FactoryMethod.B.Factory;
public static class PizzaSimpleFactory
{
    public static PizzaFactoryMethod CriarPizzaria(PizzariaLocal pizzariaLocal) => pizzariaLocal switch
    {
        PizzariaLocal.Brasil => new PizzaFactoryBrasil(),
        PizzariaLocal.Italia => new PizzaFactoryItalia(),
        _ => throw new InvalidOperationException("Error")
    };
}
