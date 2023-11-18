using FactoryMethod.C.Model;

namespace FactoryMethod.C.Alçada;
public abstract class Alcada
{
    protected string Nome { get; set; } = null!;
    protected List<Aprovadores> Aprovadores { get; set; } = new();


    public string AprovadorPor() =>
         $"{string.Join(", ", Aprovadores.Select(x => x.Nome))}";

    public string NomeAlcada() => Nome;
}
