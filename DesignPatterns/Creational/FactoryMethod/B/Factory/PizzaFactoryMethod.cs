using FactoryMethod.B.Product;

namespace FactoryMethod.B.Factory;
public abstract class PizzaFactoryMethod
{
    public Pizza MontarPizza(TipoPizza tipoPizza)
    {
        Pizza pizza = CriarPizza(tipoPizza);
        return pizza;
    }
    protected abstract Pizza CriarPizza(TipoPizza tipoPizza);
}
