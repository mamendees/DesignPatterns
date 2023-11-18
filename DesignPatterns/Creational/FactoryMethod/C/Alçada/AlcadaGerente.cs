using FactoryMethod.C.Model;

namespace FactoryMethod.C.Alçada;
public class AlcadaGerente : Alcada
{
    public AlcadaGerente()
    {
        Nome = "Alcada Gerente";
        Aprovadores.Add(new Aprovadores("Matheus Gerente", Cargo.Gerente));
        Aprovadores.Add(new Aprovadores("Matheus Diretor", Cargo.Diretor));
    }
}
