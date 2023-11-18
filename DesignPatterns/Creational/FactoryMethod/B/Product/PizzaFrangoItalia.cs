namespace FactoryMethod.B.Product;
public class PizzaFrangoItalia: Pizza
{
    public PizzaFrangoItalia()
    {
        Nome = "Pizza Frango Italia";
        Massa = "Massa Frango Italia";
        Molho = "Molho Frango Italia";
        ingredientes.Add("Frango");
        ingredientes.Add("Italia");
    }
    public override string Embalar()
    {
        return " Embalar Override";
    }
}
