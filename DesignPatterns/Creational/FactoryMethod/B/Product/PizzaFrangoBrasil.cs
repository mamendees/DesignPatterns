namespace FactoryMethod.B.Product;
public class PizzaFrangoBrasil: Pizza
{
    public PizzaFrangoBrasil()
    {
        Nome = "Pizza Frango Brasil";
        Massa = "Massa Frango Brasil";
        Molho = "Molho Frango Brasil";
        ingredientes.Add("Frango");
        ingredientes.Add("Brasil");
    }

    public override string Embalar()
    {
        return "Embalar Override";
    }
}
