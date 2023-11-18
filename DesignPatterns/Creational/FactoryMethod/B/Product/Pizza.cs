using System.Collections;

namespace FactoryMethod.B.Product;
public abstract class Pizza
{
    protected string Nome { get; set; } = null!;
    protected string Massa { get; set; } = null!;
    protected string Molho { get; set; } = null!;
    protected ArrayList ingredientes = new();


    public string Preparar()
    {
        var @string = $"{Nome} - {Massa} - {Molho}: \n Ingredientes {string.Join(", ", ingredientes.ToArray())}";
        @string += Cozinhar();
        @string += Fatiar();
        @string += Embalar();

        return @string;
    }

    public virtual string Embalar() => " Embalar padrão";

    public virtual string Fatiar() => " Fatiar padrão";

    public virtual string Cozinhar() => " Cozinhar padrão";
}
