namespace FactoryMethod.B.Product;
public class PizzaMussarelaBrasil : Pizza
{
    public PizzaMussarelaBrasil()
    {
        Nome = "Pizza Mussarela Brasil";
        Massa = "Massa Mussarela Brasil";
        Molho = "Molho Mussarela Brasil";
        ingredientes.Add("Queijo");
        ingredientes.Add("Brasil");
    }
}
