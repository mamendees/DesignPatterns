namespace FactoryMethod.B.Product;
public class PizzaMussarelaItalia : Pizza
{
    public PizzaMussarelaItalia()
    {
        Nome = "Pizza Mussarela Italia";
        Massa = "Massa Mussarela Italia";
        Molho = "Molho Mussarela Italia";
        ingredientes.Add("Queijo");
        ingredientes.Add("Italia");
    }
}
